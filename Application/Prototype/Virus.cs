namespace Prototype
{
    public class Virus
    {
        public Virus(string name, int weight, int age, string type, Virus[] childrens)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Type = type;
            Childrens = childrens;
        }
        public Virus() { }

        public string Name { get; set; }

        public int Weight { get; set; }

        public int Age { get; set; }

        public string Type { get; set; }

        public Virus[] Childrens { get; set; }

        public Virus Clone()
        {
            Virus VirusCopy = new Virus();
            VirusCopy.Name = Name;
            VirusCopy.Weight = Weight;
            VirusCopy.Age = Age;
            VirusCopy.Type = Type;

            VirusCopy.Childrens = new Virus[Childrens.Length];
            for (int i = 0; i < Childrens.Length; i++)
            {
                VirusCopy.Childrens[i] = Childrens[i].Clone();
            }


            return VirusCopy;
        }
    }
}
