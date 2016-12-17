echo Stop Paywell.PaymentServer Service...
net stop "WinServiceSample"
echo Uninstalling Paywell.PaymentServer Win Service...
@cd /d "%~dp0"
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil /u "WinServiceSample.exe"
pause
echo Done.