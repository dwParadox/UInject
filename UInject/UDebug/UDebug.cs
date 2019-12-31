using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UInject.ULog;

namespace UInject
{
    public static class UDebug
    {
        private static LogManager logManager = new LogManager(
            new List<ILogChannel> {
                //new LogToScreen(20),
                new LogToFile(@"C:\Users\Public\Documents\UInjectLog.txt")
            });

        public static void Log(LogMessageType messageType, string message)
        {
            logManager.Log(messageType, message);
        }

        public static void RenderLogger()
        {
            logManager.Render();
        }
    }
}
