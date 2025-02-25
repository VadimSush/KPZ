using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Kiaomi
{
    public class KiaomiFactory : IFactory
    {
        public IEBook CreateEBook()
        {
            return new KiaomiEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new KiaomiNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
}
