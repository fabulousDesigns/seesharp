// The ref keyword is used to pass a variable by reference. This means that any modifications inside the method will reflect outside.
//
// Key Rules of ref:
// The variable must be initialized before being passed to the method.
//     The method receives a reference to the original variable, not a copy.
//     Any modifications inside the method affect the original variable.
//     It can be used in method parameters and return values.

class Ref
{
    public void ModifyValue(ref int x)
    {
        x += 10;
    }

    public int GetLargest(ref int a, ref int b)
    {
        var getLargest = a > b ? a : b;
        return getLargest;
    }
}