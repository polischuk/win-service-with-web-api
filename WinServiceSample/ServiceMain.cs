using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace WinServiceWithOwin
{
    public partial class ServiceMain : ServiceBase
    {
        private IDisposable _server = null;
        private readonly string _baseAddress = ConfigurationManager.AppSettings["BaseAddress"];
        private readonly string _serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
        private readonly string _ipAddress = ConfigurationManager.AppSettings["IpAddress"];
        public ServiceMain()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var options = new StartOptions();
            options.Urls.Add(_baseAddress);
#if !DEBUG
                if (!string.IsNullOrWhiteSpace(_serverAddress))
                {
                    options.Urls.Add(_serverAddress);
                }
                if (!string.IsNullOrWhiteSpace(_ipAddress))
                {
                    options.Urls.Add(_ipAddress);
                }
#endif
            _server = WebApp.Start<Startup>(options);
        }

        protected override void OnStop()
        {
            _server?.Dispose();
        }

        public void OnDebug()
        {
            OnStart(null);
        }
    }
}
