using FactoryMethod.Implementations;
using FactoryMethod.Interfaces;

ISubscriptionCreator creator1 = new WebSite();
ISubscriptionCreator creator2 = new MobileApp(450);
ISubscriptionCreator creator3 = new ManagerCall();

Console.WriteLine("Створимо підписку веб сайтом");
Subscription subscription1 = creator1.CreateSubscription();
Console.WriteLine(subscription1.Type);

Console.WriteLine("Створимо підписку мобільним додатком");
Subscription subscription2 = creator2.CreateSubscription();
Console.WriteLine(subscription2.Type);

Console.WriteLine("Створимо підписку менеджером");
Subscription subscription3 = creator3.CreateSubscription();
Console.WriteLine(subscription3.Type);