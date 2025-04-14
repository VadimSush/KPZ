namespace Composite
{
    public abstract class LightNode
    {
        public abstract string GetContents(int depth = 0);

        public List<LightNode> childrens { get; protected set; }

        protected void Render()
        {
            Create();
            Insert();
            TextRender();
            StyleApply();
            ClassListApply();
        }

        public virtual void Create() { }

        public virtual void Insert() { }

        public virtual void TextRender() { }

        public virtual void StyleApply() { }

        public virtual void ClassListApply() { }
    }
}
