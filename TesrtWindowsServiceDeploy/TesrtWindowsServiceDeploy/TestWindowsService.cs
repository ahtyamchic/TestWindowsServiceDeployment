using System.ServiceProcess;
using System.Threading;
using NLog;

namespace TesrtWindowsServiceDeploy
{
  partial class TestWindowsService : ServiceBase
  {
    private  Timer _timer;
    private readonly ILogger Logger;
    public TestWindowsService()
    {
      InitializeComponent();
      Logger = LogManager.GetCurrentClassLogger();  
    }

    private void Callback(object state)
    {
      Logger.Info("Test setvice is working...");
    }

    protected override void OnStart(string[] args)
    {
      Logger.Info("Test setvice is started");
      _timer = new Timer(Callback, null, 0, 5000);    
    }

    protected override void OnStop()
    {
      Logger.Info("Test setvice is stoped");
    }

    public void TestStart()
    {
      OnStart(null);
    }

    public void TestStop()
    {
      OnStop();
    }
  }
}
