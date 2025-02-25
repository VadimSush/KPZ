
using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.IProne
{
    public class IProneEBook : IEBook
    {
        public void Info()
        {
            Console.WriteLine("IEBook");
        }
    }
}
