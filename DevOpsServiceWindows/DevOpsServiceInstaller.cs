using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Configuration;

namespace DevOpsServiceWindows
{
    [RunInstaller(true)]
    public partial class DevOpsServiceInstaller : System.Configuration.Install.Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;
        public DevOpsServiceInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            service = new ServiceInstaller();
            service.ServiceName = GetServiceName();
            service.Description = GetServiceName();
            service.StartType = ServiceStartMode.Automatic;
            Installers.Add(process);
            Installers.Add(service);

            //InitializeComponent();
        }

        private string GetServiceName()
        {
            string serviceName = DevOpsServiceInstaller.GetConfigurationValue("ServiceName");
            if (true == string.IsNullOrEmpty(serviceName))
            {
                serviceName = "Dev Ops Service";
            }
            return serviceName;
        }

        public static string GetConfigurationValue(string key)
        {
            string configValue = string.Empty;
            try
            {
                Assembly service = Assembly.GetAssembly(typeof(DevOpsServiceInstaller));
                Configuration config = ConfigurationManager.OpenExeConfiguration(service.Location);
                if (config.AppSettings.Settings[key] != null)
                {
                    configValue = config.AppSettings.Settings[key].Value;
                }
            }
            catch (Exception exp)
            {

            }
            return configValue;
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }
    }
}
