namespace Decorator
{
    public class Warrior : IWrapee
    {
        public void Attack()
        {
            Console.WriteLine("Attack with sword");
        }

        public void SayHello()
        {
            Console.WriteLine("HI!");
        }
    }
}
