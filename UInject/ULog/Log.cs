namespace UInject.ULog
{
    public struct Log
    {
        public LogMessageType MessageType { get; }
        public string Message { get; }

        public Log(LogMessageType messageType, string message)
        {
            this.MessageType = messageType;
            this.Message = message;
        }
    }
}