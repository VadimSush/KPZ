using Application.Abstractions;

namespace Application.Implemintations
{
    public class Dollar : Money
    {
        public Dollar(int intPart, int floatPart) : base(intPart, floatPart) { }

        public override string Print()
        {
            string floatString = FloatPart > 0 ? $" {FloatPart} центів" : "";
            return $"{IntPart} доларів{floatString}";
        }
    }
}
