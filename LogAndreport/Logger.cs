using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net;

namespace TestFramework.LogAndreport
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        static Logger()
        {
            var logRepository = LogManager.GetRepository(System.Reflection.Assembly.GetExecutingAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }

        public static void LogInfo(string message)
        {
            log.Info(message);
        }

        public static void LogError(string message, Exception ex = null)
        {
            log.Error(message, ex);
        }

        public static void LogDebug(string message)
        {
            log.Debug(message);
        }
    }
}
