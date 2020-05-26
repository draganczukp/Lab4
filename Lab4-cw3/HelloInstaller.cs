using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_cw3
{
    [RunInstaller(true)]

    public class HelloInstaller : Installer
    {
        private ServiceInstaller ServiceInstaller;
        private ServiceProcessInstaller ServiceProcessInstaller;

        public HelloInstaller()
        {
            ServiceProcessInstaller = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem
            };

            ServiceInstaller = new ServiceInstaller
            {
                Description = "Usługa wypisująca 'Hello World' do pliku",
                ServiceName = "HelloService",
                StartType = ServiceStartMode.Manual,
            };

            Installers.Add(ServiceProcessInstaller);
            Installers.Add(ServiceInstaller);
        }
    }
}
