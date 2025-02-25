using FactoryMethod.Interfaces;

namespace FactoryMethod.Implementations
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(500, 3, ["Some channel 1", "Some channel 2", "Some channel 3"], "Premium") { }
    }
}
