namespace Adapter
{
    public interface ILogger
    {
        public void Log(string message);

        public void Error(string message);

        public void Warn(string message);
    }
}
