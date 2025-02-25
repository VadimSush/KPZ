namespace Singleton
{
    public class Authenticator
    {
        private Authenticator() { }

        private static Authenticator _instance = null;

        private static readonly object _lock = new object();

        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
    }
}
