namespace Composite.Command
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(LightElementNode node, LightNode deleteNode) : base(node)
        {
            _deleteNode = deleteNode;
        }

        private LightNode _deleteNode;

        public override void Execute()
        {
            _node.childrens.Remove(_deleteNode);
        }

        public override void Undo()
        {
            _node.AddNode(_deleteNode);
        }
    }
}
