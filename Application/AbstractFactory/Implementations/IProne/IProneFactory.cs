using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.IProne
{
    public class IProneFactory : IFactory
    {
        public IEBook CreateEBook()
        {
            return new IProneEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }
}
