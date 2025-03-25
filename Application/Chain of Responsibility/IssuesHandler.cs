namespace Chain_of_Responsibility
{
    public class IssuesHandler : BaseHandler
    {
        public IssuesHandler(IHandler next) : base(next) { }

        public IssuesHandler() { }

        public override void Handle()
        {
            Console.WriteLine("Введіть 1, якщо у вас виникли проблеми з мобільним інтернетом. Введіть 2, якщо у вас виникли проблеми з якістю мобільного зв'язку. Введіть 3, якщо у вас виникли проблеми з нашим додатком. Натисніть будь-яку іншу клавішу, якщо вам потрібно щось інше.");

            string? res = Console.ReadLine();

            if (res == "1")
            {
                Console.WriteLine("Способи вирішення проблем з мобільним інтернетом");
            }
            else if (res == "2")
            {
                Console.WriteLine("Способи вирішення проблем з мобільним зв'язком");
            }
            else if (res == "3")
            {
                Console.WriteLine("Способи вирішення проблем з нашим мобільним додатком");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
