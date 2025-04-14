namespace Composite
{
    public abstract class LightNode
    {
        public abstract string GetContents(int depth = 0);

        public List<LightNode> childrens { get; protected set; }
    }
}
