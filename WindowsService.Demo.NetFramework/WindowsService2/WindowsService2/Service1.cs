using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\xun73\Desktop\OEM-1AASEXHA1ZW.txt";

        System.Timers.Timer timer1 = new System.Timers.Timer();
        protected override void OnStart(string[] args)
        {
            timer1.Interval = 4000;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Tick);
            File.AppendAllLines(path, new string[] { $"{DateTime.Now},服务启动！" });
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            File.AppendAllLines(path, new string[] { $"{DateTime.Now},服务停止！" });
        }

        protected override void OnContinue()
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            WindowsService2.Properties.Settings.Default.Setting++;
            //if (File.Exists(path))
            //{
            File.AppendAllLines(path, new string[] { $"{DateTime.Now.ToLongTimeString()}:Add {WindowsService2.Properties.Settings.Default.Setting} ." });
            //}
        }
    }
}
