class ParameterTester
{
    public void RegularIncrement(int number) // pass by value
    {
        number += 1;
    }

    public void RefIncrement(ref int number)
    {
        number += 1;
    }

    public void GetNumber(out int number)
    {
        number = 42;
    }
    //
    // Question 1: Implement Number Swapper
    //     Create a generic method that swaps two numbers and returns whether the first number was larger than the second before swapping. Use ref parameters.
    //     Try implementing this before looking at my solution:
    public bool SwapIfGreater<T>(ref T a, ref T b) where T : IComparable<T>
    {
        // Store if a > b
        var wasAGreater = a.CompareTo(b) > 0;
    
        // Only swap if a is greater than b
        if (wasAGreater)
        {
            (a, b) = (b, a);
        }
    
        return wasAGreater;
    }
    
}