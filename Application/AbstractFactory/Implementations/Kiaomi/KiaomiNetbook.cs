using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Kiaomi
{
    public class KiaomiNetbook : INetbook
    {
        public void Info()
        {
            Console.WriteLine("KiaomiNetbook");
        }
    }
}
