using Singleton;

Authenticator authenticator1 = Authenticator.GetInstance();
Authenticator authenticator2 = Authenticator.GetInstance();
Console.WriteLine(ReferenceEquals(authenticator1, authenticator2));
