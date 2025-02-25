using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.IProne
{
    public class IProneNetbook : INetbook
    {
        public void Info()
        {
            Console.WriteLine("IProneNetbook");
        }
    }
}
