namespace Flyweight
{
    public class LightElementNodeCache
    {
        public string tagName { get; }

        public DisplayType displayType { get; }

        public ClosureType closureType { get; }

        public List<string> classList { get; }

        public LightElementNodeCache(string tagName, DisplayType displayType, ClosureType closureType, List<string> classList)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closureType = closureType;
            this.classList = classList;
        }
    }
}
