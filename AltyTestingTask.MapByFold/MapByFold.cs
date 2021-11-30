// Problem 3: implement Map in terms of Fold. Rather than implementing Map 
// directly like the first exercise, implement Map by finding a way to call
// Fold so that it achieves the desired result.

//
// Map([1,2,3], x => x + 1) = [2,3,4]
// Map([1,2,3], x => x.ToString()) = ["1","2","3"]
// Map([], ...) == []


B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder)
{
    foreach (var item in list)
    {
        initial = folder(initial, item);
    }
    return initial;
}

List<B> Map2<A, B>(List<A> list, Func<A, B> f)
{
    return Fold<A, List<B>>(list, new List<B>(), (sum, x) => { sum.Add(f(x)); return sum; });
}

var addOneRses = Map2<int, int>(new List<int> { 1, 2, 3 }, (value) => value + 1);
var numToStrings = Map2<int, string>(new List<int> { 1, 2, 3 }, (value) => value.ToString());
Console.WriteLine("Done");