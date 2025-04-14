using System.Xml;

namespace Composite.Visitor
{
    public interface IVisitor
    {
        public string VisitElement(LightElementNode node);

        public string VisitText(LightTextNode node);
    }
}
