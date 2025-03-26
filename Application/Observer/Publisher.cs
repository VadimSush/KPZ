namespace Observer
{
    public delegate void MouseHandler(int x, int y);

    public class Publisher
    {
        public event MouseHandler? Click;

        public event MouseHandler? DoubleClick;

        public event MouseHandler? MouseOver;

        public void NotifyClick(int x, int y)
        {
            Click?.Invoke(x, y);
        }

        public void NotifyDoubleClick(int x, int y)
        {
            DoubleClick?.Invoke(x, y);
        }

        public void NotifyMouseOver(int x, int y)
        {
            MouseOver?.Invoke(x, y);
        }

        public void Subscribe(string type, MouseHandler handler)
        {
            switch (type)
            {
                case "click":
                    Click += handler;
                    break;
                case "doubleclick":
                    DoubleClick += handler;
                    break;
                case "mouseover":
                    MouseOver += handler;
                    break;
            }
        }

        public void Unsubscribe(string type, MouseHandler handler)
        {
            switch (type)
            {
                case "click":
                    Click -= handler;
                    break;
                case "doubleclick":
                    DoubleClick -= handler;
                    break;
                case "mouseover":
                    MouseOver -= handler;
                    break;
            }
        }
    }
}
