namespace Flyweight
{
    public static class LightElementNodeFactory
    {
        private static readonly List<LightElementNodeCache> _list = new();

        public static LightElementNodeCache Find(string tagName, DisplayType displayType, ClosureType closureType, List<string> classList)
        {
            var result = _list.Where(x => x.tagName == tagName && x.displayType == displayType && x.closureType == closureType && string.Join(" ", x.classList) == string.Join(" ", classList)).FirstOrDefault();

            if (result == null)
            {
                result = new LightElementNodeCache(tagName, displayType, closureType, classList);
                _list.Add(result);
            }

            return result;
        }

        public static LightElementNodeCache ChangeToDouble(LightElementNodeCache oldCache)
        {
            return Find(oldCache.tagName, oldCache.displayType, ClosureType.Double, oldCache.classList);
        }
    }
}
