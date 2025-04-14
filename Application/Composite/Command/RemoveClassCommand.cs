namespace Composite.Command
{
    public class RemoveClassCommand : Command
    {
        public RemoveClassCommand(LightElementNode node, string className) : base(node)
        {
            _className = className;
        }

        private string _className;

        public override void Execute()
        {
            _node.classList.Remove(_className);
        }

        public override void Undo()
        {
            _node.classList.Add(_className);
        }
    }
}
