using FactoryMethod.Interfaces;

namespace FactoryMethod.Implementations
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(100, 12, ["Educational channel 1", "Educational channel 2"], "Educational") { }
    }
}
