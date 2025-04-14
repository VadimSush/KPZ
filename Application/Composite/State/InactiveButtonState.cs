namespace Composite.State
{
    public class InactiveButtonState : ButtonState
    {
        public InactiveButtonState(LightButtonNode button) : base(button) { }

        public override void Click()
        {
            Console.WriteLine("Кнопка неактивна");
        }

        public override void Hover()
        {
            Console.WriteLine("Кнопка неактивна");
        }
    }
}
