using FactoryMethod.Interfaces;

namespace FactoryMethod.Implementations
{
    public class MobileApp : ISubscriptionCreator
    {
        public MobileApp(int money)
        {
            Money = money;
        }

        public int Money { get; set; }

        public Subscription CreateSubscription()
        {
            if (Money >= 500)
            {
                return new PremiumSubscription();
            }
            else if (Money >= 300)
            {
                return new DomesticSubscription();
            }
            else
            {
                return new EducationalSubscription();
            }
        }
    }
}
