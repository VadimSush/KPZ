namespace Decorator.Decorators
{
    public class BaseDecorator : IWrapee
    {
        private readonly IWrapee _wrapee;

        public BaseDecorator(IWrapee wrapee)
        {
            _wrapee = wrapee;
        }

        public virtual void Attack()
        {
            _wrapee.Attack();
        }

        public virtual void SayHello()
        {
            _wrapee.SayHello();
        }
    }
}
