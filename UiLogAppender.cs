using System;
using log4net.Appender;
using log4net.Core;

namespace TouchMPCGtk
{
    public class UiLogAppender : IAppender
    {
        public void Close()
        {
        }

        public void DoAppend(LoggingEvent loggingEvent)
        {
            if (Program.MainWindow != null)
                Program.MainWindow.PushLog(loggingEvent);
        }

        public string Name { get; set; }
    }
}