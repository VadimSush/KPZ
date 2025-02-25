using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Balaxy
{
    public class BalaxyLaptop : ILaptop
    {
        public void Info()
        {
            Console.WriteLine("BalaxyLaptop");
        }
    }
}
