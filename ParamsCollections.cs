namespace dotnet9test;
// Allows for a variable number of arguments to be passed to a method with collection types instead of only arrays.
public class ParamsCollections
{
   public void PrintList(params IEnumerable<string> list) => Console.WriteLine(string.Join(", ", list));
}