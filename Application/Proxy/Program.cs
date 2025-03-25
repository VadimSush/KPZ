using Proxy;

File.WriteAllText("./file.txt", "Hello!\nSome text\nText Text te");

ITextReader loggerTextReader = new SmartTextChecker(new SmartTextReader());

ITextReader lockerTextReader = new SmartTextReaderLocker(new SmartTextReader(), ".+file.+");

loggerTextReader.ReadFile("./file.txt");

lockerTextReader.ReadFile("./file.txt");

