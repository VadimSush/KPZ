using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    IntPart = 0;
                }
                else
                {
                    IntPart = value;
                }
            }
        }

        private int _floatPart;
        public float FloatPart
        {
            get { return _floatPart; }
            set
            {
                if (value < 0)
                {
                    FloatPart = 0;
                }
                else if (value > 99)
                {
                    FloatPart = 99;
                }
                else
                {
                    FloatPart = value;
                }
            }
        }

        public abstract void Print();
    }
}
