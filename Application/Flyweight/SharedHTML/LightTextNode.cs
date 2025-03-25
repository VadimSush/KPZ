namespace Flyweight
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string GetContents(int depth = 0)
        {
            return new string(' ', depth) + _text;
        }
    }
}
