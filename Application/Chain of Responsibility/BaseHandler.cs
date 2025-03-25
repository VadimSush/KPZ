namespace Chain_of_Responsibility
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _next;

        public BaseHandler(IHandler next)
        {
            _next = next;
        }

        public BaseHandler() { }

        public virtual void Handle()
        {
            if (_next != null)
            {
                _next.Handle();
            }
        }

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }
    }
}
