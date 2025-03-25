using System.Text;

namespace Flyweight
{
    public class LightElementNodeParent : LightNode
    {
        private List<LightNode> childrens;

        private int childrenCount;

        private LightElementNodeCache lightNodeCache;

        public LightElementNodeParent(string tagName, DisplayType displayType, IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double)
        {
            lightNodeCache = LightElementNodeFactory.Find(tagName, displayType, closureType, classList.ToList());
            if (childrens != null && childrens.Any())
            {
                this.childrens = childrens.ToList();
                childrenCount = this.childrens.Count;
                if (closureType == ClosureType.Single)
                {
                    lightNodeCache = LightElementNodeFactory.ChangeToDouble(lightNodeCache);
                }
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
            if (lightNodeCache.closureType == ClosureType.Single)
            {
                lightNodeCache = LightElementNodeFactory.ChangeToDouble(lightNodeCache);
            }
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

            string classes = lightNodeCache.classList.Count > 0 ? " class=\"" + string.Join(" ", lightNodeCache.classList) + "\"" : "";

            builder.Append($"<{lightNodeCache.tagName}{classes}{(lightNodeCache.closureType == ClosureType.Single ? "/" : "")}>");

            if (lightNodeCache.closureType == ClosureType.Double)
            {
                builder.AppendLine();
            }

            builder.Append(GetInnerHTML(depth + 2));

            if (lightNodeCache.closureType == ClosureType.Double)
            {
                builder.Append(new string(' ', depth));
                builder.Append($"</{lightNodeCache.tagName}>");
            }

            return builder.ToString();
        }

        public override string GetContents(int depth = 0)
        {
            return GetOuterHTML(depth);
        }
    }
}
