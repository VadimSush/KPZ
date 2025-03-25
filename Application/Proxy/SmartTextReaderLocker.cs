using System.Text.RegularExpressions;

namespace Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader _textReader;
        private readonly string _reg;

        public SmartTextReaderLocker(ITextReader textReader, string reg)
        {
            _textReader = textReader;
            _reg = reg;
        }

        public IEnumerable<char[]> ReadFile(string path)
        {
            if (Regex.IsMatch(path, _reg))
            {
                Console.WriteLine("Access denied");
                return null;
            }

            return _textReader.ReadFile(path);
        }
    }
}
