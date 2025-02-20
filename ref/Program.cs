class Program
{
    static void Main()
    {
        int num1 = 5, num2 = 23;
       // Console.WriteLine($"Before: {num1}");
        var refObj = new Ref();
       //  refObj.ModifyValue(ref num1);
       // Console.WriteLine($"After: {num1}");
       var max =  refObj.GetLargest(ref num1, ref num2);
       Console.WriteLine($"After: {max}");
        
    }
}