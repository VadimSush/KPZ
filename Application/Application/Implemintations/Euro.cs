using Application.Abstractions;

namespace Application.Implemintations
{
    public class Euro : Money
    {
        public Euro(int intPart, int floatPart) : base(intPart, floatPart) { }

        public override string Print()
        {
            string floatString = FloatPart > 0 ? $" {FloatPart} євроцентів" : "";
            return $"{IntPart} євро{floatString}";
        }
    }
}
