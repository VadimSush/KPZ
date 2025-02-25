namespace FactoryMethod.Interfaces
{
    public abstract class Subscription
    {
        protected Subscription(int subscriptionFee, int minimalSubscriptionTerm, string[] channelList, string type)
        {
            SubscriptionFee = subscriptionFee;
            MinimalSubscriptionTerm = minimalSubscriptionTerm;
            ChannelList = channelList;
            Type = type;
        }
        public int SubscriptionFee { get; private set; }

        public int MinimalSubscriptionTerm { get; private set; }

        public string[] ChannelList { get; private set; }
        
        public string Type { get; private set; }

    }
}
