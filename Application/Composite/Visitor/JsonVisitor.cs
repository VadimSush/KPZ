using System.Text.Json;
using System.Text.Json.Nodes;

namespace Composite.Visitor
{
    public class JsonVisitor : IVisitor
    {
        public JsonVisitor()
        {
            stack.Push(new JsonArray());
        }

        private Stack<JsonArray> stack = new Stack<JsonArray>();

        public string VisitElement(LightElementNode node)
        {
            JsonObject root = new JsonObject();

            stack.Peek().Add(root);

            root.Add("name", JsonValue.Create(node.tagName));
            root.Add("class", JsonValue.Create(string.Join(" ", node.classList)));
            root.Add("display", JsonValue.Create((node.displayType == LightElementNode.DisplayType.Block) ? "Block" : "Inline"));
            root.Add("closure", JsonValue.Create((node.closureType == LightElementNode.ClosureType.Double) ? "Double" : "Single"));

            JsonArray childrens = new JsonArray();
            root.Add("childrens", childrens);
            stack.Push(childrens);

            foreach (LightNode childNode in node.childrens)
            {
                childNode.Convert(this);
            }
            stack.Pop();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            return root.ToJsonString(options);

        }

        public string VisitText(LightTextNode node)
        {
            JsonObject root = new JsonObject();

            root.Add("name", JsonValue.Create("text"));
            root.Add("text", JsonValue.Create(node._text));

            stack.Peek().Add(root);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            return root.ToJsonString(options);
        }
    }
}
