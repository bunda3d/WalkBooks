# Generates an ASCII directory tree and writes it into README.md
# Excludes .git/bin/obj/node_modules/tmp/publish/.vs
# place in path: tools/generate-tree.ps1

# called locally by running in PShell from the root of the repository (..\WalkBooks\)
# pwsh .\tools\generate-tree.ps1 -Depth 2

param(
  [string]$Path = '.',
  [int]$Depth = 2,
  [string[]]$Exclude = @('.git','bin','obj','node_modules','tmp','publish','.vs'),
  [string]$OutputFile = 'README.md'
)

# remove previous output if present
Remove-Item -ErrorAction Ignore -Force $OutputFile

function Write-Tree {
  param($Path, $Prefix = '', $Level = 0)
  if ($Level -gt $Depth) { return }

  # get children, exclude unwanted names
  $items = Get-ChildItem -LiteralPath $Path -Force |
    Where-Object { -not ($Exclude -contains $_.Name) } |
    # sort so directories come first, then by name
    Sort-Object -Property @{ Expression = { -not $_.PSIsContainer } }, @{ Expression = { $_.Name } }

  for ($i = 0; $i -lt $items.Count; $i++) {
    $item = $items[$i]
    $isLast = ($i -eq $items.Count - 1)
    $branch = if ($isLast) { '└─ ' } else { '├─ ' }
    $line = $Prefix + $branch + $item.Name
    $line | Out-File -FilePath $OutputFile -Append -Encoding utf8
    if ($item.PSIsContainer) {
      if ($isLast) {
        $newPrefix = $Prefix + '   '
      } else {
        $newPrefix = $Prefix + '│  '
      }
      Write-Tree -Path $item.FullName -Prefix $newPrefix -Level ($Level + 1)
    }
  }
}

# header
@(
  '# WalkBooks Project Structure',
  '',
  "Below is an auto-generated directory map (depth: $Depth).",
  'Regenerate by running GitHub Action Workflow "Update Directory Tree".',
  ''
) | Out-File -FilePath $OutputFile -Encoding utf8

'.' | Out-File -FilePath $OutputFile -Append -Encoding utf8
Write-Tree -Path (Resolve-Path $Path).Path -Prefix '' -Level 0

Write-Host "Wrote $OutputFile"
