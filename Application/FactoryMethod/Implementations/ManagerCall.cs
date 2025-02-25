using FactoryMethod.Interfaces;

namespace FactoryMethod.Implementations
{
    public class ManagerCall : ISubscriptionCreator
    {
        public Subscription CreateSubscription()
        {
            Console.Write("Оберіть тип підписки: ");
            string type = Console.ReadLine();

            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    return new DomesticSubscription();
            }
        }
    }
}
