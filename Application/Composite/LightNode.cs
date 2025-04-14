using Composite.Visitor;
using System.Xml;
using Composite.Iterator;
using System.Collections;

namespace Composite
{
    public abstract class LightNode : IEnumerable<LightNode>
    {
        public LightNode()
        {
            _enumerator = new DepthIterator(this);
        }

        public abstract string GetContents(int depth = 0);

        private IEnumerator<LightNode> _enumerator;

        public List<LightNode> childrens { get; protected set; }


        public abstract string Convert(IVisitor visitor);

        public IEnumerator<LightNode> GetEnumerator()
        {
            return _enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _enumerator;
        }

        public void SetIterator(IEnumerator<LightNode> enumerator)
        {
            _enumerator = enumerator;
        }
    }
}
