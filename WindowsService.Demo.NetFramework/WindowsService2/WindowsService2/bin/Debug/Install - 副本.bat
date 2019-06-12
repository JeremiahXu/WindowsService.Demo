sc create WindowsService2 binPath="C:\Users\xun73\Desktop\WindowsService2\WindowsService2\bin\Debug\WindowsService2.exe"

sc Start WindowsService2

sc config WindowsService2 start= auto

sc config WindowsService2 DisplayName="服务程序显示的名称"

pause