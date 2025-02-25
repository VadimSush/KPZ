using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations.Balaxy
{
    public class BalaxyFactory : IFactory
    {
        public IEBook CreateEBook()
        {
            return new BalaxyEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new BalaxyNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
    }
}
