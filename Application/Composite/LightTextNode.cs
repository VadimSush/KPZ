namespace Composite
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text) : base()
        {
            _text = text;
            childrens = new List<LightNode>();
        }

        public override string GetContents(int depth = 0)
        {
            return new string(' ', depth) + _text;
        }
    }
}
