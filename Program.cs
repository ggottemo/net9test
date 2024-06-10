// See https://aka.ms/new-console-template for more information

using dotnet9test;

Console.WriteLine("Hello, World!");

ParamsCollections pc = new ParamsCollections();
pc.PrintList(new List<string> { "a", "b", "c" });
string sequence = "\e[31mThis text is red\e[0m";
Console.WriteLine(sequence);
string escapeCharacter = "\e";

int count = 0;
int numberOfThreads = 100;

List<Thread> threads = new List<Thread>();

Lockingkeyword lk = new Lockingkeyword();
for (int i = 0; i < 1000; i++)
{
    // spawn multiple threads
    Thread t = new Thread(() =>
    {
        lk.SafeIncrement(ref count);
        Console.WriteLine($"THREAD {Thread.CurrentThread.ManagedThreadId} incrementing count to {count}");
    });
    threads.Add(t);
    t.Start();

    lk.SafeIncrement(ref count);

}

foreach (var thread in threads)
{
    thread.Join();
}
lk.SafeIncrement(ref count);
Console.WriteLine(count);

// Method Group Natural Types
//  not in yet?
// void LogMessage(int number) => Console.WriteLine(number);
// Action<int> logNumber = LogMessage;
// void LogMessage(string message) => Console.WriteLine(message);
// Action<string> log = LogMessage;
// log("Test");
//
// void ShowInfo(string info) => Console.WriteLine(info);
// void ShowInfo(int value) => Console.WriteLine(value);
//
//
// var display = (Action<string>)ShowInfo;
// display("Hello");
//
// bool Compare(int a, int b) => a == b;
// bool Compare(string a, string b) => a.Equals(b);
//
// Func<int, int, bool> compareInts = Compare;
// Console.WriteLine(compareInts(5, 5));

// Implicit Indexer Access in Object Initializers
// The ^ operator can be used in object initializers to access elements from the end.
// var list = new List<int> { 1, 2, 3, 4, 5 };
// var initializer = new { Values = new { [^1] = 10 } };
//
// var numbers = new int[4] { 10, 20, 30, 40 };
// var config = new { Configurations = new { [^3] = 99 } };
//
//
// var data = new double[3] { 1.1, 2.2, 3.3 };
// var init = new { Values = { [^1] = 0.0 } };


public class Person
{
    public int Age { get; set; }
}

public implicit extension PersonExtensions for Person {
public bool IsAdult => this.Age >= 18;
}

var person = new Person { Age = 20 };
Console.WriteLine(person.IsAdult);

ReadOnlySpan<byte> span = "Hello, World"u8;

