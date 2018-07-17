@cd /d "%~dp0"
echo Installing service...
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil "WinServiceSample.exe"
echo Start Service
net start "WinServiceSample"
pause
echo Done.
