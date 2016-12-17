using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinServiceWithOwin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

#if DEBUG
            var paymentServerService = new ServiceMain();
            paymentServerService.OnDebug();
            Thread.Sleep(Timeout.Infinite);
#else

            var servicesToRun = new ServiceBase[]
            {
                new ServiceMain(),
            };
            ServiceBase.Run(servicesToRun);
#endif
        }
    }
}
