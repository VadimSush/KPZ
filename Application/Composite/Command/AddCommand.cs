namespace Composite.Command
{
    public class AddCommand : Command
    {
        public AddCommand(LightElementNode node, LightNode newNode) : base(node)
        {
            _newNode = newNode;
        }

        private LightNode _newNode;

        public override void Execute()
        {
            _node.AddNode(_newNode);
        }

        public override void Undo()
        {
            _node.childrens.Remove(_newNode);
        }
    }
}
