// Problem 2: Implement the following method Fold
// 
// Fold applies a function to each element of a list and propagates a state
// through calls to this function, starting with the initial state.
//
// Fold([1,2,3], 0, (sum,x) => sum + x) == 6
// Fold([1,2,3], "", (str,x) => str + x.ToString()) == "123"
// Fold([], init, ...) == init
B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder)
{
    foreach (var item in list)
    {
        initial = folder(initial, item);
    }
    return initial;
}

var numResult = Fold<int, int>(new List<int>() { 1, 3, 4 }, 0, (sum, x) => sum + x);
var stringResult = Fold<int, string>(new List<int>() { 1, 3, 4 }, "", (sum, x) => sum + x.ToString());
Console.WriteLine("Done");