namespace Decorator
{
    public class Palladin : IWrapee
    {
        public void Attack()
        {
            Console.WriteLine("Attack with hammer");
        }

        public void SayHello()
        {
            Console.WriteLine("Good day!");
        }
    }
}
