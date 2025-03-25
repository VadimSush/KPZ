using Bridge.Implementations;

namespace Bridge.Abstractions
{
    public abstract class Canvas
    {
        protected readonly Shape _shape;

        protected Canvas(Shape shape)
        {
            _shape = shape;
        }

        public abstract void Draw();
    }
}
