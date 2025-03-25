namespace Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader _textReader;

        public SmartTextChecker(ITextReader textReader)
        {
            _textReader = textReader;
        }

        public IEnumerable<char[]> ReadFile(string path)
        {
            try
            {
                var result = _textReader.ReadFile(path);
                Console.WriteLine("<LOG>: File was opened");
                Console.WriteLine("<LOG>: File was read");
                Console.WriteLine("<LOG>: File was closed");
                Console.WriteLine($"<LOG>: File has {result.Count()} lines");
                Console.WriteLine($"<LOG>: File has {result.Select(x => x.Length).Sum()} symbols");
                return result;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"<ERROR>: File was not opened! Exception: {ex.Message}");
                return null;
            }
        }
    }
}
