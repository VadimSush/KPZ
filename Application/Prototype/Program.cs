using Prototype;

Virus virus1 = new Virus("Alex", 100, 20, "virus", []);
Virus virus2 = new Virus("Alexx", 140, 23, "virus", []);
Virus virus11 = new Virus("Bob", 1, 1, "virussuper", [virus1, virus2]);
Virus virus12 = new Virus("Katy", 333, 234, "virussuper", []);
Virus virus111 = new Virus("Kris", 55, 230, "father", [virus11, virus12]);

Virus copy = virus111.Clone();

Console.WriteLine(virus111.Childrens[0].Childrens[0].Name);
Console.WriteLine(copy.Childrens[0].Childrens[0].Name);

virus111.Childrens[0].Childrens[0].Name = "New Name";

Console.WriteLine(virus111.Childrens[0].Childrens[0].Name);
Console.WriteLine(copy.Childrens[0].Childrens[0].Name);