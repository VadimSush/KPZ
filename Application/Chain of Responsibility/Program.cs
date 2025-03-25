using Chain_of_Responsibility;

IHandler handler4 = new ChatHandler();
IHandler handler3 = new IssuesHandler(handler4);
IHandler handler2 = new TariffHandler(handler3);
IHandler handler1 = new InfoHandler(handler2);
handler4.SetNext(handler1);

handler1.Handle();