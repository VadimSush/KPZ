namespace Strategy
{
    public class Image : LightElementNode
    {
        public string Href { get; }

        private readonly UploadStrategy _strategy;

        public Image(string href, IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double) : base("image", DisplayType.Inline, classList, childrens, closureType)
        {
            Href = href;
            if (href.StartsWith("www") || href.StartsWith("http"))
            {
                _strategy = new InternetUploadStrategy();
            }
            else
            {
                _strategy = new FileUploadStrategy();
            }
        }

        public void Upload()
        {
            _strategy.Upload(Href);
        }
    }
}
