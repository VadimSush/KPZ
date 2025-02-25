namespace AbstractFactory.Interfaces
{
    public interface IFactory
    {
        public ILaptop CreateLaptop();

        public INetbook CreateNetbook();

        public IEBook CreateEBook();

        public ISmartphone CreateSmartphone();
    }
}
