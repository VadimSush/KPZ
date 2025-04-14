namespace Composite.Command
{
    public class AddClassCommand : Command
    {
        public AddClassCommand(LightElementNode node, string className) : base(node)
        {
            _className = className;
        }

        private string _className;

        public override void Execute()
        {
            _node.classList.Add(_className);
        }

        public override void Undo()
        {
            _node.classList.Remove(_className);
        }
    }
}
