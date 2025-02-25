using FactoryMethod.Interfaces;

namespace FactoryMethod.Implementations
{
    public class WebSite : ISubscriptionCreator
    {
        public string SubscriptionType { get; set; } = "Premium"; 
        public Subscription CreateSubscription()
        {
            switch (SubscriptionType)
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
