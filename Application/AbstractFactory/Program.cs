using AbstractFactory.Implementations.Balaxy;
using AbstractFactory.Implementations.IProne;
using AbstractFactory.Implementations.Kiaomi;
using AbstractFactory.Interfaces;

IFactory factory1 = new IProneFactory();
IFactory factory2 = new KiaomiFactory();
IFactory factory3 = new BalaxyFactory();

ILaptop laptop1 = factory1.CreateLaptop();
laptop1.Info();

ILaptop laptop2 = factory2.CreateLaptop();
laptop2.Info();

INetbook netbook2 = factory2.CreateNetbook();
netbook2.Info();

INetbook netbook3 = factory3.CreateNetbook();
netbook3.Info();