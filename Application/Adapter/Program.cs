using Adapter;

File.WriteAllText("./file.txt", "");

ILogger fileLogger = new FileLogger("./file.txt");

fileLogger.Log("Test info 1");

fileLogger.Warn("Warn info 333");

fileLogger.Error("ERROR!!!");

Console.WriteLine(File.ReadAllText("./file.txt"));