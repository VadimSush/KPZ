namespace Adapter
{
    public class FileLogger : ILogger
    {
        private readonly FileWriter _adaptee;

        public string FilePath { get; set; }

        public FileLogger(string filePath)
        {
            _adaptee = new FileWriter();
            FilePath = filePath;
        }

        public void Log(string message)
        {
            _adaptee.WriteLine(FilePath, "<LOG>: " + message);
        }

        public void Error(string message)
        {
            _adaptee.WriteLine(FilePath, "<ERROR>: " + message);
        }

        public void Warn(string message)
        {
            _adaptee.WriteLine(FilePath, "<WARN>: " + message);
        }
    }
}
