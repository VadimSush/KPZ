namespace Chain_of_Responsibility
{
    public class ChatHandler : BaseHandler
    {
        public ChatHandler(IHandler next) : base(next) { }

        public ChatHandler() { }

        public override void Handle()
        {
            Console.WriteLine("Введіть 1, якщо хочете зв'язатись з нашим помічником. Введіть 2, якщо хочете зв'язатись з оператором. Натисніть будь-яку іншу клавішу, якщо вам потрібно щось інше.");

            string? res = Console.ReadLine();

            if (res == "1")
            {
                Console.WriteLine("Зв'язок з ботом");
            }
            else if (res == "2")
            {
                Console.WriteLine("Зв'язок з оператором");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
