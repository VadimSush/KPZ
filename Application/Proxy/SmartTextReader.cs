namespace Proxy
{
    public class SmartTextReader : ITextReader
    {
        public IEnumerable<char[]> ReadFile(string path)
        {
            string[] stringArr = File.ReadAllLines(path);

            return stringArr.Select(x => x.ToCharArray());
        }
    }
}
