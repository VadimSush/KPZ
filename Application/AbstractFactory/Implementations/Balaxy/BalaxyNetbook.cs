using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Balaxy
{
    public class BalaxyNetbook : INetbook
    {
        public void Info()
        {
            Console.WriteLine("BalaxyNetbook");
        }
    }
}
