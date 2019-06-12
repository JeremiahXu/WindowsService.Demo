%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe C:\Users\xun73\Desktop\WindowsService2\WindowsService2\bin\Debug\WindowsService2.exe

Net Start WindowsService2

sc config WindowsService2 start= auto

pause