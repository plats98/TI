using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;

namespace TI.ReportPlus.BLL
{
    public class Logger
    {
        private static bool _Debug_Level = false;
        private static bool _Info_Level = true;
        private static bool _Warn_Level = false;

        public Logger()
        {
            ReloadLevels();
        }

        public static void ReloadLevels()
        {
            bool level;

            if (!Boolean.TryParse(Property.Get("LoggerLevel_INFO"), out level)) { } // TODO: The parsing attempt failed
            Info_Level = level;

            if (!Boolean.TryParse(Property.Get("LoggerLevel_WARN"), out level)) { } // TODO: The parsing attempt failed
            Warn_Level = level;

            if (!Boolean.TryParse(Property.Get("LoggerLevel_DEBUG"), out level)) { } // TODO: The parsing attempt failed
            Debug_Level = level;
        }

        public static bool Debug_Level
        {
            get
            {
                return _Debug_Level;
            }

            set
            {
                _Debug_Level = value;
            }
        }

        public static bool Info_Level
        {
            get
            {
                return _Info_Level;
            }

            set
            {
                _Info_Level = value;
            }
        }

        public static bool Warn_Level
        {
            get
            {
                return _Warn_Level;
            }

            set
            {
                _Warn_Level = value;
            }
        }

        public static void Setup()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller;

            // Debug logger (DEBUG)
            if (Debug_Level)
            {
                roller = new RollingFileAppender();
                roller.AppendToFile = true;
                roller.File = @"C:\Logs\Debug.log";
                roller.Layout = patternLayout;
                roller.MaxSizeRollBackups = 5;
                roller.MaximumFileSize = "100MB";
                roller.RollingStyle = RollingFileAppender.RollingMode.Size;
                roller.StaticLogFileName = true;
                roller.Threshold = Level.Debug;
                roller.ActivateOptions();
                hierarchy.Root.AddAppender(roller);
            }

            // Event logger (INFO)
            if (Info_Level)
            {
                roller = new RollingFileAppender();
                roller.AppendToFile = true;
                roller.File = @"C:\Logs\Event.log";
                roller.Layout = patternLayout;
                roller.MaxSizeRollBackups = 5;
                roller.MaximumFileSize = "100MB";
                roller.RollingStyle = RollingFileAppender.RollingMode.Size;
                roller.StaticLogFileName = true;
                roller.Threshold = Level.Info;
                roller.ActivateOptions();
                hierarchy.Root.AddAppender(roller);
            }

            // Error logger (WARN)
            if (Warn_Level)
            {
                roller = new RollingFileAppender();
                roller.AppendToFile = true;
                roller.File = @"C:\Logs\Error.err";
                roller.Layout = patternLayout;
                roller.MaxSizeRollBackups = 5;
                roller.MaximumFileSize = "100MB";
                roller.RollingStyle = RollingFileAppender.RollingMode.Size;
                roller.StaticLogFileName = true;
                roller.Threshold = Level.Warn;
                roller.ActivateOptions();
                hierarchy.Root.AddAppender(roller);
            }

            //MemoryAppender memory = new MemoryAppender();
            //memory.ActivateOptions();
            //hierarchy.Root.AddAppender(memory);

            //hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;
        }
    }
}
