// Problem 1: Implement the following method Map without using library methods 
// (ie no Linq).
//
// Map applies a function to each element of a list and returns the 
// resulting list.
//
// Map([1,2,3], x => x + 1) = [2,3,4]
// Map([1,2,3], x => x.ToString()) = ["1","2","3"]
// Map([], ...) == []


List<B> Map<A, B>(List<A> list, Func<A, B> f)
{
    var result = new List<B>();
    foreach (var item in list)
    {
        result.Add(f(item));
    }
    return result;
}

var addOneres = Map<int, int>(new List<int> { 1, 2, 3 }, (value) => value + 1);
var numToStrings = Map<int, string>(new List<int> { 1, 2, 3 }, (value) => value.ToString());

Console.WriteLine("Map([1,2,3], x => x + 1) = [2,3,4]");
Console.Write("Answer: ");
addOneres.ForEach(v => Console.Write($"{v} "));
Console.WriteLine();
Console.WriteLine("_________________________________________________________");
Console.WriteLine("Map([1,2,3], x => x.ToString()) = ['1','2','3']");
Console.Write("Answer: ");
numToStrings.ForEach(v => Console.Write($"{v} "));

Console.WriteLine();
