namespace Chain_of_Responsibility
{
    public class InfoHandler : BaseHandler
    {
        public InfoHandler(IHandler next) : base(next) { }

        public InfoHandler() { }

        public override void Handle()
        {
            Console.WriteLine("Добрий день! Введіть 1, якщо хочете отримати інформацію про мобільного оператора. Введіть 2, якщо хочете отримати інформацію про свій тарифний план. Натисніть будь-яку іншу клавішу, якщо вам потрібно щось інше.");
            string? res = Console.ReadLine();

            if (res == "1")
            {
                Console.WriteLine("Інформація про мобільного оператора");
            }
            else if (res == "2") 
            {
                Console.WriteLine("Інформація про ваш тарифний план");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
