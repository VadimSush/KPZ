namespace Decorator.Decorators
{
    public class ClothesDecorator : BaseDecorator
    {
        private readonly string _clothes;

        public ClothesDecorator(IWrapee wrapee, string clothes) : base(wrapee)
        {
            _clothes = clothes;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hero adjusts his {_clothes}");

            base.SayHello();
        }
    }
}
