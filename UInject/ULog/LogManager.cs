using System;
using System.Collections.Generic;

namespace UInject.ULog
{
    public enum LogMessageType : int
    {
        INFO,
        ERROR
    }

    public class LogManager
    {
        private readonly IList<ILogChannel> channels;

        public LogManager(IList<ILogChannel> logChannels)
        {
            if (logChannels == null)
                throw new ArgumentNullException("logChannels", "You must specify a log channel.");

            this.channels = new List<ILogChannel>(logChannels);
        }

        public void Log(LogMessageType messageType, string message)
        {
            foreach (var c in channels)
                c.Log(messageType, message);
        }

        public void Render()
        {
            foreach (var c in channels)
                c.Render();
        }
    }
}