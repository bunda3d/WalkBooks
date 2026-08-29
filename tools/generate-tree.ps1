# Generates an ASCII directory tree and writes it into README.md
# Excludes bin/obj/node_modules/tmp/publish
# place in path: tools/generate-tree.ps1

$tree = tree -a -I "bin|obj|node_modules|tmp|publish" | Out-String

$header = @"
# WalkBooks Project Structure

Below is an auto-generated directory map.  
Run the GitHub Action or execute tools/generate-tree.ps1 locally to regenerate.

"@

$footer = @"


"@

Set-Content -Path "./README.md" -Value ($header + $tree + $footer)
