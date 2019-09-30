using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsServiceWindows
{
    public partial class DevOpsServiceBase : ServiceBase
    {
        public DevOpsServiceBase()
        {
            ServiceName = "DevOpsService";
        }

        //private void InitializeComponent()
        //{
        //    this.ServiceName = "DevOpsService";
        //}

        protected override void OnStart(string[] args)
        {
            StartService();
        }


        protected override void OnStop()
        {
        }

//        public static void Main()
//        {

//            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

//#if DEBUG

//            (new DevOpsServiceBase()).StartService();
//            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
//#else

//                        ServiceBase.Run(new EngineServiceBase());
//#endif

//        }

        //private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{

        //}

        private void StartService()
        {

        }
    }
}
