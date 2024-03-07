# powershell-wine-wrapper

## How to use:

1. Install Powershell from https://github.com/PowerShell/PowerShell/releases/tag/v7.4.1 - ([x86 ](https://github.com/PowerShell/PowerShell/releases/download/v7.4.1/PowerShell-7.4.1-win-x86.msi)or [x64](https://github.com/PowerShell/PowerShell/releases/download/v7.4.1/PowerShell-7.4.1-win-x64.msi)) (Should work with other versions but not tested). The command should be:
```bash
wine PowerShell-7.4.1-win-xXX.msi
```
2. Backup the existing powershell in Wine based on the arch you're using:
```bash
x86 - $HOME/.wine/drive_c/windows/system32/WindowsPowerShell/v1.0/powershell.exe
x64 - $HOME/.wine/drive_c/windows/syswow64/WindowsPowerShell/v1.0/powershell.exe
```
3. Extract the matching architecture zip from this repo into the corresponding location
4. You should now be able to issue Powershell commands, test with:
```bash
WINEDEBUG=-all wine powershell -command echo "This is awesome!"
```
