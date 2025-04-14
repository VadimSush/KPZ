using System.Collections;

namespace Composite.Iterator
{
    public class DepthIterator : IEnumerator<LightNode>
    {
        public DepthIterator(LightNode node)
        {
            _node = node;
            _stack.Push(node);
        }

        private readonly LightNode _node;

        private readonly Stack<LightNode> _stack = new Stack<LightNode>();

        public LightNode Current => _stack.Peek();

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (_stack.Count != 0)
            {
                LightNode node = _stack.Pop();
                for (int i = node.childrens.Count - 1; i >= 0; i--)
                {
                    _stack.Push(node.childrens[i]);
                }
                if (_stack.Count != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _stack.Clear();
            _stack.Push(_node);
        }
    }
}
