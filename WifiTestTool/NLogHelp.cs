using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;
using System.Configuration;

namespace WifiTestTool
{
    public static class NLogHelp
    {
        //private static int MaxArchiveTime = Convert.ToInt16(ConfigurationManager.AppSettings["LogTime"]);

        public static bool WriteLog(string message, string IP)
        {
            try
            {
                LoggingConfiguration config = new LoggingConfiguration();
                FileTarget fileTarget = new FileTarget();

                config.AddTarget("file", fileTarget);
                fileTarget.FileName = "${basedir}/log/${shortdate}_" + IP + ".log";
                fileTarget.Layout = "${longdate} ${message}";

                fileTarget.ArchiveFileName = "${basedir}/log/${shortdate}_" + IP + ".log";
                fileTarget.ArchiveEvery = FileArchivePeriod.Day;
                fileTarget.ArchiveNumbering = ArchiveNumberingMode.Rolling;
                fileTarget.MaxArchiveFiles = 7;
                fileTarget.ConcurrentWrites = true;
                fileTarget.KeepFileOpen = false;

                LoggingRule rule = new LoggingRule("*", LogLevel.Info, fileTarget);
                config.LoggingRules.Add(rule);

                LogManager.Configuration = config;

                Logger logger = LogManager.GetLogger("Example");

                logger.Log(LogLevel.Info, message);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
