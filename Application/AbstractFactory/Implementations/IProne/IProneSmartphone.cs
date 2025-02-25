
using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.IProne
{
    public class IProneSmartphone : ISmartphone
    {
        public void Info()
        {
            Console.WriteLine("IProneSmartphone");
        }
    }
}
