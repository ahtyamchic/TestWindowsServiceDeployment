using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace TesrtWindowsServiceDeploy
{
  [RunInstaller(true)]
  public partial class WindowsServiceInstaller : System.Configuration.Install.Installer
  {
    private readonly ServiceProcessInstaller process;
    private readonly ServiceInstaller service;
    public WindowsServiceInstaller()
    {
      InitializeComponent();

      process = new ServiceProcessInstaller { Account = ServiceAccount.NetworkService };
      service = new ServiceInstaller { ServiceName = "GameBI.Test.JobService", StartType = ServiceStartMode.Automatic };
      Installers.Add(process);
      Installers.Add(service);
    }
  }
}
