using System.Text;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> childrens;

        private string tagName;
        
        private DisplayType displayType;

        private ClosureType closureType;

        private List<string> classList;

        private int childrenCount;

        public LightElementNode(string tagName, DisplayType displayType, IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double)
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
