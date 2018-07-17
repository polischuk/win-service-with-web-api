echo Stop service...
net stop "WinServiceSample"
echo Uninstalling Win Service...
@cd /d "%~dp0"
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil /u "WinServiceSample.exe"
pause
echo Done.
