# powershell-wine-wrapper

## Requirements:
Built with .NET 8.0

Get and install the runtime from [Microsoft](https://download.visualstudio.microsoft.com/download/pr/a4bc7333-6e30-4e2d-b300-0b4f23537e5b/4b81af6d46a02fba5d9ce030af438c67/dotnet-runtime-8.0.2-win-x64.exe)

## How to use:

1. Install Powershell from https://github.com/PowerShell/PowerShell/releases/tag/v7.4.1 - ([x86 ](https://github.com/PowerShell/PowerShell/releases/download/v7.4.1/PowerShell-7.4.1-win-x86.msi)or [x64](https://github.com/PowerShell/PowerShell/releases/download/v7.4.1/PowerShell-7.4.1-win-x64.msi)) (Should work with other versions but not tested). The command should be:
```bash
wine PowerShell-7.4.1-win-xXX.msi
```
2. Backup the following existing powershell.exe in Wine based on the arch you're using:
```bash
x86 - $HOME/.wine/drive_c/windows/system32/WindowsPowerShell/v1.0/powershell.exe
x64 - $HOME/.wine/drive_c/windows/syswow64/WindowsPowerShell/v1.0/powershell.exe
```
3. Extract the matching architecture zip from this repo into the corresponding location
4. You should now be able to issue Powershell commands, test with:
```bash
WINEDEBUG=-all wine powershell -command echo "This is awesome!"
```
