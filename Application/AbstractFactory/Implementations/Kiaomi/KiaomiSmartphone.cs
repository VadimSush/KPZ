
using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Kiaomi
{
    public class KiaomiSmartphone : ISmartphone
    {
        public void Info()
        {
            Console.WriteLine("KiaomiSmartphone");
        }
    }
}
