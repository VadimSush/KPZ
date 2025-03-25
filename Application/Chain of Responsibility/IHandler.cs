namespace Chain_of_Responsibility
{
    public interface IHandler
    {
        public void SetNext(IHandler handler);

        public void Handle();
    }
}
