using Composite.Visitor;
using System.Text;
using System.Xml;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        public string tagName { get; protected set; }

        public DisplayType displayType { get; protected set; }

        public ClosureType closureType { get; protected set; }

        public List<string> classList { get; protected set; }

        private int childrenCount;

        public LightElementNode(string tagName, DisplayType displayType, IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double) : base()
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closureType = closureType;
            this.classList = classList.ToList();
            if (childrens != null && childrens.Any())
            {
                this.childrens = childrens.ToList();
                childrenCount = this.childrens.Count;
                this.closureType = ClosureType.Double;
            }
            else
            {
                this.childrens = new List<LightNode>();
            }
            Render();
        }

        public void AddNode(LightNode node)
        {
            childrenCount++;
            childrens.Add(node);
            closureType = ClosureType.Double;
        }

        public string GetInnerHTML(int depth = 0)
        {
            StringBuilder builder = new StringBuilder();

            foreach (LightNode node in childrens)
            {
                builder.Append(node.GetContents(depth));
                builder.AppendLine();
            }

            return builder.ToString();
        }

        public string GetOuterHTML(int depth = 0)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(new string(' ', depth));

            string classes = classList.Count > 0 ? " class=\"" + string.Join(" ", classList) + "\"" : "";

            builder.Append($"<{tagName}{classes}{(closureType == ClosureType.Single ? "/" : "")}>");

            if (closureType == ClosureType.Double)
            {
                builder.AppendLine();
            }

            builder.Append(GetInnerHTML(depth + 2));

            if (closureType == ClosureType.Double)
            {
                builder.Append(new string(' ', depth));
                builder.Append($"</{tagName}>");
            }

            return builder.ToString();
        }

        public override string GetContents(int depth = 0)
        {
            return GetOuterHTML(depth);
        }

        public override void Create()
        {
            Console.WriteLine($"Створення {tagName}-елементу");
        }
        
        public override string Convert(IVisitor visitor)
        {
            return visitor.VisitElement(this);
        }

        public enum DisplayType
        {
            Inline,
            Block
        }

        public enum ClosureType
        {
            Single,
            Double
        }
    }
}
