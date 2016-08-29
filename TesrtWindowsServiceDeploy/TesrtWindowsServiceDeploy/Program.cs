using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TesrtWindowsServiceDeploy
{
  class Program
  {
    static void Main(string[] args)
    {
#if DEBUG
      var service = new TestWindowsService();
      service.TestStart();
      Console.ReadLine();
      service.TestStop();
#else
      ServiceBase.Run(new TestWindowsService());
#endif
    }
  }
}
