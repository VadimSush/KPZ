using System.Xml;

namespace Composite.Visitor
{
    public class XmlVisitor : IVisitor
    {
        public XmlVisitor()
        {
            _doc = new XmlDocument();
            _stack.Push(_doc);
        }

        private XmlDocument _doc;

        private Stack<XmlNode> _stack = new Stack<XmlNode>();

        public string VisitElement(LightElementNode node)
        {
            XmlElement root = _doc.CreateElement(node.tagName);

            _stack.Push(root);

            CreateXmlElement(node, root);

            _stack.Peek().AppendChild(root);

            return root.OuterXml;
        }

        public string VisitText(LightTextNode node)
        {
            XmlElement root = _doc.CreateElement("text");

            root.InnerText = node._text;

            _stack.Peek().AppendChild(root);

            return _doc.OuterXml;
        }

        private void CreateXmlElement(LightElementNode node, XmlElement element)
        {
            XmlAttribute className = _doc.CreateAttribute("class");
            className.Value = string.Join(" ", node.classList);
            element.Attributes.Append(className);

            XmlAttribute display = _doc.CreateAttribute("displayType");
            display.Value = (node.displayType == LightElementNode.DisplayType.Block) ? "Block" : "Inline";
            element.Attributes.Append(display);

            XmlAttribute closure = _doc.CreateAttribute("closureType");
            closure.Value = (node.closureType == LightElementNode.ClosureType.Double) ? "Double" : "Single";
            element.Attributes.Append(closure);

            foreach (LightNode childNode in node.childrens)
            {
                childNode.Convert(this);
            }

            _stack.Pop();
        }
    }
}
