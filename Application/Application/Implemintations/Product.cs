using Application.Abstractions;

namespace Application.Implemintations
{
    public class Product
    {
        public Product(string name, Money price, string units, int amount, DateTime lastDelivery)
        {
            Name = name;
            Price = price;
            Units = units;
            Amount = amount;
            LastDelivery = lastDelivery;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Money _price;
        public Money Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _units;
        public string Units
        {
            get { return _units; }
            set { _units = value; }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set
            {
                if (value < 0)
                {
                    _amount = 0;
                }
                else
                {
                    _amount = value;
                }
            }
        }

        private DateTime _lastDelivery;
        public DateTime LastDelivery
        {
            get { return _lastDelivery; }
            set { _lastDelivery = value; }
        }

        public void ReducePrice(int intPart, int floatPart = 0)
        {
            if (!IsCorrectMoney(intPart, floatPart))
            {
                Console.WriteLine("Некоректні значення параметрів");
                return;
            }

            int resultPrice = Price.IntPart * 100 + Price.FloatPart - intPart * 100 + floatPart;

            if (resultPrice < 0)
            {
                Console.WriteLine("Ви передали завеликі параметри, товар коштує менше");
                return;
            }

            NumberToMoney(resultPrice);
        }

        public void IncreasePrice(int intPart, int floatPart = 0)
        {
            if (!IsCorrectMoney(intPart, floatPart))
            {
                Console.WriteLine("Некоректні значення параметрів");
                return;
            }

            int resultPrice = Price.IntPart * 100 + Price.FloatPart + intPart * 100 + floatPart;

            NumberToMoney(resultPrice);
        }

        private bool IsCorrectMoney(int intPart, int floatPart)
        {
            return intPart >= 0 && floatPart >= 0 && floatPart < 100;
        }

        private void NumberToMoney(int num)
        {
            Price.IntPart = num / 100;
            Price.FloatPart = num % 100;
        }
    }
}
