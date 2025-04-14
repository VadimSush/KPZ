using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Composite.Iterator
{
    public class BreadthIterator : IEnumerator<LightNode>
    {
        public BreadthIterator(LightNode node)
        {
            _node = node;
            _queue.Enqueue(node);
        }

        private readonly LightNode _node;

        private readonly Queue<LightNode> _queue = new Queue<LightNode>();

        public LightNode Current => _queue.Peek();

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (_queue.Count != 0)
            {
                LightNode node = _queue.Dequeue();
                foreach (LightNode newNode in node.childrens)
                {
                    _queue.Enqueue(newNode);
                }
                if (_queue.Count != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _queue.Clear();
            _queue.Enqueue(_node);
        }
    }
}
