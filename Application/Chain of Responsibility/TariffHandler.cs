namespace Chain_of_Responsibility
{
    public class TariffHandler : BaseHandler
    {
        public TariffHandler(IHandler next) : base(next) { }

        public TariffHandler() { }

        public override void Handle()
        {
            Console.WriteLine("Введіть 1, якщо у вас виникли проблеми з поповненням мобільного рахунку. Введіть 2, якщо хочете відмовитись від тарифного плану. Натисніть будь-яку іншу клавішу, якщо вам потрібно щось інше.");

            string? res = Console.ReadLine();

            if (res == "1")
            {
                Console.WriteLine("Способи вирішення проблем з поповненням");
            }
            else if (res == "2")
            {
                Console.WriteLine("Ви відмовились від тарифного плану :(");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
