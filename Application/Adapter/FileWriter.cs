namespace Adapter
{
    public class FileWriter
    {
        public void Write(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        public void WriteLine(string path, string line)
        {
            File.AppendAllText(path, line + "\n");
        }
    }
}
