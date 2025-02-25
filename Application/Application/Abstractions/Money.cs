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

        public abstract string Print();
    }
}
