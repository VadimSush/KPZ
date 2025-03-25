namespace Decorator.Decorators
{
    public class ArtefactDecorator : BaseDecorator
    {
        private readonly string _artifact;

        public ArtefactDecorator(IWrapee wrapee, string artifact) : base(wrapee)
        {
            _artifact = artifact;
        }

        public override void Attack()
        {
            Console.WriteLine($"Use {_artifact}");

            base.Attack();
        }
    }
}
