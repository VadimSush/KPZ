using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.IProne
{
    public class IProneLaptop : ILaptop
    {
        public void Info()
        {
            Console.WriteLine("IProneLaptop");
        }
    }
}
