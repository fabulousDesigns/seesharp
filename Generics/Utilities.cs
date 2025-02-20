/*
 * Create a regular (non-generic) class called Utilities that has these generic methods:
 * Swap<T> - takes two parameters of type T and swaps their values
 * PrintArray<T> - takes an array of type T and prints all elements
 * Find<T> - takes an array of type T and an item to find, returns the index of the item (-1 if not found)
 * Some hints:
 * - Generic methods use the <T> syntax right before the return type
 * - You'll need to use the ref keyword for the Swap method to make it work
 * - For Find, you'll need to use Equals method to compare objects
 */
 
class Utilities
{
    public void Swap<T>(ref T param1, ref T param2)
    {
        (param1, param2) = (param2, param1);
    }

    public void PrintArray<T>(T[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine();
    }
    
    public int Find<T>(T[] arr, T item)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(item))
            {
                return i;
            }
        }
        return -1; // Not found
    }
}