using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Kiaomi
{
    public class KiaomiLaptop : ILaptop
    {
        public void Info()
        {
            Console.WriteLine("KiaomiLaptop");
        }
    }
}
