using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Balaxy
{
    public class BalaxyEBook : IEBook
    {
        public void Info()
        {
            Console.WriteLine("BalaxyEBook");
        }
    }
}
