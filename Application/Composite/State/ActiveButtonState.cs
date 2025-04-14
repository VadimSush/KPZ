namespace Composite.State
{
    public class ActiveButtonState : ButtonState
    {
        public ActiveButtonState(LightButtonNode button) : base(button) { }

        public override async void Click()
        {
            if (_button.ClickAction != null)
            {
                _button.SetState(new InactiveButtonState(_button));
                await _button.ClickAction();
                _button.SetState(new ActiveButtonState(_button));
            }
        }

        public override async void Hover()
        {
            if (_button.HoverAction != null)
            {
                await _button.HoverAction();
            }
        }
    }
}
