namespace UInject.ULog
{
    public interface ILogChannel
    {
        void Log(LogMessageType messageType, string message);
        void Render();
    }
}