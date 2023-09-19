using Singletone;

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;
Console.WriteLine($"logger1 has the same instance as logger2: {object.ReferenceEquals(logger1, logger2)}");




