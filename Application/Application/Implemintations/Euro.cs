using Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implemintations
{
    public class Euro : Money
    {
        public Euro(int intPart, int floatPart) : base(intPart, floatPart) { }

        public override void Print()
        {
            string floatString = FloatPart > 0 ? $" {FloatPart} євроцентів" : "";
            Console.WriteLine($"{IntPart} євро{floatString}");
        }
    }
}
