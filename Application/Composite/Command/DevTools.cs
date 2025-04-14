namespace Composite.Command
{
    public class DevTools
    {
        public DevTools(LightElementNode document)
        {
            _document = document;
        }

        private LightElementNode _document;
        
        private Stack<Command> _commandHistory = new Stack<Command>();

        public void AddNode(LightElementNode parent, LightNode node)
        {
            Command command = new AddCommand(parent, node);
            Execute(command);
        }

        public void RemoveNode(LightElementNode parent, LightNode node)
        {
            Command command = new RemoveCommand(parent, node);
            Execute(command);
        }

        public void AddClass(LightElementNode node, string className)
        {
            Command command = new AddClassCommand(node, className);
            Execute(command);
        }

        public void RemoveClass(LightElementNode node, string className)
        {
            Command command = new RemoveClassCommand(node, className);
            Execute(command);
        }

        public void Undo()
        {
            Command command = _commandHistory.Pop();
            command.Undo();
        }

        private void Execute(Command command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }
    }
}
