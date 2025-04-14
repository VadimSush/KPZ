
namespace Composite.TemplateMethod
{
    public class LightDivNode : LightElementNode
    {
        public LightDivNode(IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double) : base("div", DisplayType.Block, classList, childrens, closureType)
        {
        }

        public override void StyleApply()
        {
            Console.WriteLine("Застосування стилів до div-елементу");
        }

        public override void ClassListApply()
        {
            Console.WriteLine("Застосування класів до div-елементу");
        }
    }
}
