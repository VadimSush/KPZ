using System;

namespace Application.Abstractions
{
    public abstract class Money
    {
        public Money(int intPart, int floatPart)
        {
            IntPart = intPart;
            FloatPart = floatPart;
        }

        private int _intPart;
        public int IntPart
        {
            get { return _intPart; }
            set
            {
                if (value < 0)
                {
                    _intPart = 0;
                }
                else
                {
                    _intPart = value;
                }
            }
        }

        private int _floatPart;
        public int FloatPart
        {
            get { return _floatPart; }
            set
            {
                if (value < 0)
                {
                    _floatPart = 0;
                }
                else if (value > 99)
                {
                    _floatPart = 99;
                }
                else
                {
                    _floatPart = value;
                }
            }
        }

        public void ReduceMoney(int intPart, int floatPart)
        {
            if (!IsCorrectMoney(intPart, floatPart))
            {
                throw new Exception("Некоректні значення параметрів");
            }

            int resultPrice = IntPart * 100 + FloatPart - intPart * 100 + floatPart;

            if (resultPrice < 0)
            {
                throw new Exception("Ви передали завеликі параметри, товар коштує менше");
            }

            NumberToMoney(resultPrice);
        }

        public void IncreaseMoney(int intPart, int floatPart)
        {
            if (!IsCorrectMoney(intPart, floatPart))
            {
                throw new Exception("Некоректні значення параметрів");
            }

            int resultPrice = IntPart * 100 + FloatPart + intPart * 100 + floatPart;

            NumberToMoney(resultPrice);
        }

        public abstract string Print();

        private bool IsCorrectMoney(int intPart, int floatPart)
        {
            return intPart >= 0 && floatPart >= 0 && floatPart < 100;
        }

        private void NumberToMoney(int num)
        {
            IntPart = num / 100;
            FloatPart = num % 100;
        }
    }
}
