// Question:
// Write a generic method Swap<T> that swaps the values of two variables.
//
//     Expected Usage:
// int a = 5, b = 10;
// Swap(ref a, ref b);
// Console.WriteLine($"{a}, {b}"); // Output: 10, 5


// Question:
// Create a generic method PrintElements<T> that prints all elements of a List<T>.
//
// Expected Usage:
// List<string> names = new() { "Alice", "Bob", "Charlie" };
// PrintElements(names); 
// Output: Alice Bob Charlie


// Question:
// Create a generic method GetMax<T> that returns the maximum of two values. The type T should implement IComparable<T> to allow comparison.
//
//     Expected Usage:
// Console.WriteLine(GetMax(10, 20));  // Output: 20
// Console.WriteLine(GetMax("Apple", "Banana"));  // Output: Banana




class Generics
{
    public void Swap<T>(ref T param1, ref T param2)
    {
        (param1, param2) = (param2, param1);
    }

    public void PrintElements<T>(IEnumerable<T> list)
    {
        foreach (var lst in list)
        {
            Console.WriteLine($"{lst}");
        }
        
    }

    public T GetMax<T>(T valueOne, T valueTwo) where T : IComparable
    {
        var maxValue = valueOne.CompareTo(valueTwo) > 0 ? valueOne : valueTwo;
        return maxValue;
    }
}