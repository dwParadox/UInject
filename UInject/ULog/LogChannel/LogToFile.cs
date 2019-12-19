using System;
using System.IO;

namespace UInject.ULog
{
    public class LogToFile : ILogChannel
    {
        private readonly string _filePath;


        public LogToFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException("filePath", "You must specify a file to write to.");

            this._filePath = filePath;
        }

        public void Log(LogMessageType messageType, string message)
        {
            using (var streamWriter = new StreamWriter(_filePath, true))
            {
                streamWriter.WriteLine("[" + messageType.ToString() + "]: " + message);
            }
        }

        public void Render()
        {

        }
    }
}