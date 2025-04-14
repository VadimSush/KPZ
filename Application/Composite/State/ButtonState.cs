namespace Composite.State
{
    public abstract class ButtonState
    {
        public ButtonState(LightButtonNode button)
        {
            _button = button;
        }

        protected LightButtonNode _button;

        public abstract void Click();

        public abstract void Hover();
    }
}
