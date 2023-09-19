using Singletone;

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;
Console.WriteLine($"logger1 has the same instance as logger2: {object.ReferenceEquals(logger1, logger2)}");

//FileLogger fileLogger1 = Logger.Instance;
//FileLogger fileLogger2 = new FileLogger();
//Console.WriteLine($"fileLogger1 has the same instance as fileLogger2: {object.ReferenceEquals(fileLogger1, fileLogger2)}");


//ConsoleLogger consoleLogger = new ConsoleLogger();
//DatabaseLogger databaseLogger = new DatabaseLogger();

//fileLogger.LogToFile("This is fileLogger");
//consoleLogger.LogToConsole("This is consoleLogger");
//databaseLogger.LogToDatabase("This is databaseLogger");

// Check if child loggers have the same instance as the parent logger.
//bool fileLoggerHasSameInstance = object.ReferenceEquals(logger, parentLogger);
//bool consoleLoggerHasSameInstance = object.ReferenceEquals(consoleLogger, parentLogger);
//bool databaseLoggerHasSameInstance = object.ReferenceEquals(databaseLogger, parentLogger);


//Console.WriteLine($"ConsoleLogger has the same instance as parent: {consoleLoggerHasSameInstance}");
//Console.WriteLine($"DatabaseLogger has the same instance as parent: {databaseLoggerHasSameInstance}");



Parent parent = SingletonManager<Parent>.Instance;
Child1 child1 = SingletonManager<Child1>.Instance;
Child2 child2 = SingletonManager<Child2>.Instance;

// Check if child1 and child2 share the same instance as the parent
Console.WriteLine(object.ReferenceEquals(child1, parent)); // True
Console.WriteLine(object.ReferenceEquals(child2, parent)); // True

// Calling methods of Parent, Child1, and Child2
parent.ParentMethod(); // Parent Method Called
child1.Child1Method(); // Child1 Method Called
child2.Child2Method(); // Child2 Method Called


public class SingletonManager<T> where T : class, new()
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}

public class Parent
{
    public void ParentMethod()
    {
        Console.WriteLine("Parent Method Called");
    }
}

public class Child1 : Parent
{
    public void Child1Method()
    {
        Console.WriteLine("Child1 Method Called");
    }
}

public class Child2 : Parent
{
    public void Child2Method()
    {
        Console.WriteLine("Child2 Method Called");
    }
}

