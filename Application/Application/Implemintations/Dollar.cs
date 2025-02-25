using Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implemintations
{
    public class Dollar : Money
    {
        public Dollar(int intPart, int floatPart) : base(intPart, floatPart) { }

        public override void Print()
        {
            string floatString = FloatPart > 0 ? $" {FloatPart} центів" : "";
            Console.WriteLine($"{IntPart} доларів{floatString}");
        }
    }
}
