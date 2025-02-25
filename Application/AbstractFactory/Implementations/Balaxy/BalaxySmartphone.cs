using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Balaxy
{
    public class BalaxySmartphone : ISmartphone
    {
        public void Info()
        {
            Console.WriteLine("BalaxySmartphone");
        }
    }
}
