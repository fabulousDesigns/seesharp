/*
 * 
 * This challenge will teach you about generic constraints.
 * Create a generic class called Calculator<T> that can only work with numeric types.
 * The class should:
 * Only accept types that are numbers (hint: use where T : struct, IComparable)
 * Have methods:
 * Max(T a, T b) that returns the larger number
 * Min(T a, T b) that returns the smaller number
 * Add(T a, T b) that adds two numbers
 * Subtract(T a, T b) that subtracts b from a
 * This challenge will teach you:
 * How to restrict generic types to specific types using constraints
 * Why we need constraints
 * How to work with numeric comparisons in generics
 * When you encounter challenges (especially with the Add and Subtract methods),
 * This is a great opportunity to learn about some of the limitations of generics as well!
 *
 */

public class Calculator<T> where T : struct, IComparable
{
    public T Max(T a, T b)
    {
        // CompareTo returns:
        // positive number if a > b
        // 0 if a == b
        // negative number if a < b
        return a.CompareTo(b) > 0 ? a : b;
    }

    public T Min(T a, T b)
    {
        return a.CompareTo(b) < 0 ? a : b;
    }

    public T Add(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;
        return da + db;
    }

    public T Subtract(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;
        return da - db;
    }
}