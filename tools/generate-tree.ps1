<#
.SYNOPSIS
  Generate an ASCII directory tree and inject it into README.md inside a FOOTER block.

.DESCRIPTION
  - Generates a compact ASCII tree (├─, └─, │) to a temporary file.
  - Replaces the marker region between <!-- TREE-START --> and <!-- TREE-END --> with a fenced code block (no markers left).
  - If README lacks the FOOTER block, the script appends a canonical FOOTER (with markers) first.
  - On success: replace the entire FOOTER block with the Project Structure header + fenced tree (no markers left).
  - On failure: remove the entire FOOTER block (including markers) when RemoveOnFail is true.

.EXAMPLE
  - Place in path: tools/generate-tree.ps1
  - Temp file: The generated tree is written to a temporary file before being injected into the README.
  - Excludes: .git, bin, obj, node_modules, tmp, publish, .vs
  - Usage: pwsh .\tools\generate-tree.ps1 -Depth 2
#>

param(
  [string]$Path = '.',
  [int]$Depth = 2,
  [string[]]$Exclude = @('.git','bin','obj','node_modules','tmp','publish','.vs'),
  [string]$TmpFile = 'tree.tmp',
  [string]$ReadmeFile = 'README.md',
  [switch]$RemoveOnFail
)

# default RemoveOnFail to true unless explicitly provided
if (-not $PSBoundParameters.ContainsKey('RemoveOnFail')) { $RemoveOnFail = $true }

function Write-Tree {
  param($Path, $Prefix = '', $Level = 0, $OutFile)
  if ($Level -gt $Depth) { return }

  $items = Get-ChildItem -LiteralPath $Path -Force -ErrorAction SilentlyContinue |
    Where-Object { -not ($Exclude -contains $_.Name) } |
    Sort-Object -Property @{ Expression = { -not $_.PSIsContainer } }, @{ Expression = { $_.Name } }

  for ($i = 0; $i -lt $items.Count; $i++) {
    $item = $items[$i]
    $isLast = ($i -eq $items.Count - 1)
    $branch = if ($isLast) { '└─ ' } else { '├─ ' }
    $line = $Prefix + $branch + $item.Name
    $line | Out-File -FilePath $OutFile -Append -Encoding utf8
    if ($item.PSIsContainer) {
      $newPrefix = if ($isLast) { $Prefix + '   ' } else { $Prefix + '│  ' }
      Write-Tree -Path $item.FullName -Prefix $newPrefix -Level ($Level + 1) -OutFile $OutFile
    }
  }
}

# footer template (contains markers)
$footerTemplate = @"
<!--FOOTER-START-->

## WalkBooks Project Structure

Below is an auto-generated directory map (depth: $Depth).
Regenerate by running GitHub Action Workflow "Update Directory Tree" or run locally:
`pwsh .\tools\generate-tree.ps1 -Depth $Depth`

<!-- TREE-START -->
<!-- TREE-END -->

<!--FOOTER-END-->
"@.TrimEnd()

# --- generate tree to tmp file ---
Remove-Item -ErrorAction Ignore -Force $TmpFile
try {
  '.' | Out-File -FilePath $TmpFile -Encoding utf8
  Write-Tree -Path (Resolve-Path $Path).Path -Prefix '' -Level 0 -OutFile $TmpFile
  $treeText = (Get-Content -Raw -LiteralPath $TmpFile) -replace "^\s+|\s+$",""
  $treeExists = ($treeText.Length -gt 0)
} catch {
  Write-Host "Tree generation failed: $($_.Exception.Message)"
  $treeExists = $false
}

if (-not (Test-Path $ReadmeFile)) {
  Write-Host "README.md not found at path: $ReadmeFile"
  Remove-Item -ErrorAction Ignore -Force $TmpFile
  exit 1
}

# --- load README and footer pattern ---
$content = Get-Content -Raw -LiteralPath $ReadmeFile
$footerStart = '<!--FOOTER-START-->'
$footerEnd   = '<!--FOOTER-END-->'
$footerPattern = [regex]::Escape($footerStart) + '.*?' + [regex]::Escape($footerEnd)

# If footer missing, append canonical footer (so subsequent runs always find markers)
if (-not ($content -match $footerPattern)) {
  $content = $content.TrimEnd() + "`n`n" + $footerTemplate + "`n"
  $content | Out-File -FilePath $ReadmeFile -Encoding utf8
  Write-Host "Appended canonical FOOTER block to README (markers added)."
}

# reload content (in case we appended)
$content = Get-Content -Raw -LiteralPath $ReadmeFile

# Build fenced block (no markers inside)
if ($treeExists) {
  $treeText = Get-Content -Raw -LiteralPath $TmpFile
  $fencedBlock = '```' + "`n" + $treeText.TrimEnd() + "`n" + '```'
  # Replacement: header + instruction + fenced block (no markers)
  $sectionHeader = "## WalkBooks Project Structure`n`nBelow is an auto-generated directory map (depth: $Depth).`n`n"
  $instruction = "Regenerate by running GitHub Action Workflow `"Update Directory Tree`" `nor run locally: ``pwsh .\tools\generate-tree.ps1 -Depth $Depth``.`n`n"
  $replacement = $sectionHeader + $instruction + $fencedBlock + "`n"
  # Replace entire footer region with replacement (markers removed)
  $newContent = [regex]::Replace($content, $footerPattern, [System.Text.RegularExpressions.MatchEvaluator]{ param($m) $replacement }, 'Singleline')
  $newContent | Out-File -FilePath $ReadmeFile -Encoding utf8
  Remove-Item -Force $TmpFile -ErrorAction SilentlyContinue
  Write-Host "Injected tree into README (footer replaced; markers removed)."
  exit 0
}

# --- tree did not generate ---
if ($RemoveOnFail) {
  # Remove the entire FOOTER block (including markers) if present
  if ($content -match $footerPattern) {
    $final = [regex]::Replace($content, $footerPattern, '', 'Singleline')
    $final = $final.TrimEnd() + "`n"
    $final | Out-File -FilePath $ReadmeFile -Encoding utf8
    Write-Host "Tree generation failed; removed FOOTER block from README."
  } else {
    Write-Host "Tree generation failed; no FOOTER block found to remove."
  }
} else {
  Write-Host "Tree generation failed; leaving README unchanged."
}

Remove-Item -ErrorAction Ignore -Force $TmpFile
exit 0
