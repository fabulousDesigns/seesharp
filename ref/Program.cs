class Program
{
    static void Main()
    {
        // int num1 = 5, num2 = 23;
       // Console.WriteLine($"Before: {num1}");
       // var refObj = new Ref();
       //  refObj.ModifyValue(ref num1);
       // Console.WriteLine($"After: {num1}");
       // var max =  refObj.GetLargest(ref num1, ref num2);
       // Console.WriteLine($"After: {max}");
       ParameterTester tester = new ParameterTester();

       // int num1 = 5;
       // Console.WriteLine($"Before regular: {num1}"); // 5
       // tester.RegularIncrement(num1);
       // Console.WriteLine($"After regular: {num1}"); // Still 5 (didn't change)
       //
       // // Test ref parameter
       // int num2 = 5;
       // Console.WriteLine($"Before ref: {num2}"); // 5
       // tester.RefIncrement(ref num2);
       // Console.WriteLine($"After ref: {num2}"); // 6 (changed!)
       //
       // // Test out parameter
       // int num3; // Don't need to initialize
       // tester.GetNumber(out num3);
       // Console.WriteLine($"After out: {num3}"); // 42

       // int x = 10, y = 5;
       // Console.WriteLine($"Before: x = {x}, y = {y}");
       // var wasGreater = tester.SwapIfGreater(ref x, ref y);
       // Console.WriteLine($"After: x = {x}, y = {y}");
       // Console.WriteLine($"First number was greater: {wasGreater}");
       //
       // // Try with numbers where first is smaller
       // int m = 3, n = 7;
       // Console.WriteLine($"\nBefore: m = {m}, n = {n}");
       // wasGreater = tester.SwapIfGreater(ref m, ref n);
       // Console.WriteLine($"After: m = {m}, n = {n}");
       // Console.WriteLine($"First number was greater: {wasGreater}");
       // var refAndOutParams = new RefAndOutParams();
       // double[] numbers = { 10, 5, 15, 8, 20 };
       // double min, max, avg;
       //
       // Console.WriteLine("Original array: " + string.Join(", ", numbers));
       // refAndOutParams.CalculateStats(ref numbers, out min, out max, out avg);
       //
       // Console.WriteLine($"Min: {min}");
       // Console.WriteLine($"Max: {max}");
       // Console.WriteLine($"Average: {avg}");
       // Console.WriteLine("Normalized array: " + string.Join(", ", numbers));
       
       // Test the circular buffer
       var buffer = new CircularBuffer<int>(3); // Buffer size of 3

       Console.WriteLine("Adding elements 1, 2, 3:");
       buffer.Add(1);
       buffer.Add(2);
       buffer.Add(3);
       buffer.PrintBuffer();

       Console.WriteLine("\nAdding element 4 (should replace oldest element):");
       buffer.Add(4);
       buffer.PrintBuffer();

       Console.WriteLine("\nModifying element at index 1 using ref return:");
       ref int elementRef = ref buffer.GetAt(1);
       elementRef = 99;
       buffer.PrintBuffer();

       Console.WriteLine("\nTrying to modify oldest element:");
       int newValue = 50;
       if (buffer.TryModifyOldest(ref newValue))
       {
           Console.WriteLine($"Oldest element was swapped with {newValue}");
       }
       buffer.PrintBuffer();


    }
}