
public sealed class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        // Log the message to a file, database, etc.
        Console.WriteLine($"Log: {message}");
    }
}

// This will cause a compile-time error because Logger is sealed
// public class MyLogger : Logger
// {
// }