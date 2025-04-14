namespace Composite.TemplateMethod
{
    public class LightImageNode : LightElementNode
    {
        public LightImageNode(IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double) : base("image", DisplayType.Inline, classList, childrens, closureType)
        {
        }

        public override void Insert()
        {
            Console.WriteLine("Вставка картинки");
        }

        public override void ClassListApply()
        {
            Console.WriteLine("Застосування класів до image-елементу");
        }
    }
}
