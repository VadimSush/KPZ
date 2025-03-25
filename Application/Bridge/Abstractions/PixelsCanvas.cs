using Bridge.Implementations;

namespace Bridge.Abstractions
{
    public class PixelsCanvas : Canvas
    {
        public PixelsCanvas(Shape shape) : base(shape) { }

        public override void Draw()
        {
            _shape.DrawShape();

            Console.WriteLine(" as pixels");
        }
    }
}
