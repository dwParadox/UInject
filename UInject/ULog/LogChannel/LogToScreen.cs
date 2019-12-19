using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace UInject.ULog
{
    public class LogToScreen : ILogChannel
    {
        private readonly List<Log> logs;
        private readonly float logBufferSize;

        public int DisplayCount { get; set; }

        public LogToScreen(int displayCount)
        {
            this.logs = new List<Log>();
            this.logBufferSize = 20.0f;
            this.DisplayCount = displayCount;
        }

        public void Log(LogMessageType messageType, string message)
        {
            if (logs.Count >= DisplayCount)
                logs.RemoveAt(0);

            logs.Add(new Log(messageType, message));
        }

        public void Render()
        {
            if (logs.Count == 0)
                return;

            int logsIterated = 0;
            foreach (var log in Enumerable.Reverse(logs))
            {
                GUI.color = log.MessageType == LogMessageType.ERROR ? Color.red : Color.cyan;

                GUI.Label(new Rect(25f, Screen.height - 25f - logsIterated * logBufferSize, 1000, 20), "[" + log.MessageType.ToString() + "]: " + log.Message);

                GUI.color = Color.white;

                logsIterated++;
            }
        }
    }
}