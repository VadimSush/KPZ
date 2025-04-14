using Composite.Visitor;
using System.Xml;

namespace Composite
{
    public class LightTextNode : LightNode
    {
        public string _text { get; private set; }

        public LightTextNode(string text) : base()
        {
            _text = text;
            childrens = new List<LightNode>();
            Render();
        }

        public override string GetContents(int depth = 0)
        {
            return new string(' ', depth) + _text;
        }

        public override string Convert(IVisitor visitor)
        {
            return visitor.VisitText(this);
        }
    }
}
