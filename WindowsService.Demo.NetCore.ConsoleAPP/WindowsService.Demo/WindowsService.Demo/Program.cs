using System;
using System.ServiceProcess;

namespace WindowsService.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] services = new ServiceBase[] { new WinService() };

            ServiceBase.Run(services);
            //Console.WriteLine("Hello World!");
        }
    }
}
