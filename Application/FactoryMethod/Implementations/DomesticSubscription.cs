using FactoryMethod.Interfaces;

namespace FactoryMethod.Implementations
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(300, 3, ["Some channel 1", "Some channel 2"], "Domestic") { }
    }
}
