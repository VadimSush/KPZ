using Bridge.Implementations;

namespace Bridge.Abstractions
{
    public class VectorCanvas : Canvas
    {
        public VectorCanvas(Shape shape) : base(shape) { }

        public override void Draw()
        {
            _shape.DrawShape();
            Console.WriteLine(" as vectors");
        }
    }
}
