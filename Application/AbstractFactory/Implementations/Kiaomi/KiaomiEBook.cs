
using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Kiaomi
{
    public class KiaomiEBook : IEBook
    {
        public void Info()
        {
            Console.WriteLine("KiaomiEBook");
        }
    }
}
