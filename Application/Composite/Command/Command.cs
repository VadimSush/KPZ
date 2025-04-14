namespace Composite.Command
{
    public abstract class Command
    {
        public Command(LightElementNode node)
        {
            _node = node;
        }

        protected LightElementNode _node;

        public abstract void Execute();

        public abstract void Undo();
    }
}
