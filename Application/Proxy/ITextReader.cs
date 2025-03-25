namespace Proxy
{
    public interface ITextReader
    {
        public IEnumerable<char[]> ReadFile(string path);
    }
}
