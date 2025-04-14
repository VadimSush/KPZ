
namespace Composite.State
{
    public class LightButtonNode : LightElementNode
    {
        public LightButtonNode(IEnumerable<string> classList, IEnumerable<LightNode> childrens = null, ClosureType closureType = ClosureType.Double, Func<Task> click = null, Func<Task> hover = null) : base("button", DisplayType.Inline, classList, childrens, closureType)
        {
            ClickAction = click;
            HoverAction = hover;
            _state = new ActiveButtonState(this);
        }

        private ButtonState _state;

        public Func<Task> ClickAction { get; set; }

        public Func<Task> HoverAction { get; set; }

        public void Click()
        {
            _state.Click();
        }

        public void Hover()
        {
            _state.Hover();
        }

        public void SetState(ButtonState state)
        {
            _state = state;
        }
    }
}
