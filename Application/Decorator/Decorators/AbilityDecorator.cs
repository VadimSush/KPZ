namespace Decorator.Decorators
{
    public class AbilityDecorator : BaseDecorator
    {
        private readonly string _ability;

        public AbilityDecorator(IWrapee wrapee, string ability) : base(wrapee)
        {
            _ability = ability;
        }

        public override void Attack()
        {
            Console.WriteLine($"Use {_ability}");

            base.Attack();
        }
    }
}
