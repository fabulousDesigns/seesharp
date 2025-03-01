class Program
{
    static void Main()
    {
        var numbers = new int[5];
        var matrix = new[,]
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };
        Console.WriteLine(matrix[2,1]);
        Span<int> stackArray = stackalloc int[5]; // Allocated on stack, faster access
        
        int[] nums = [3, 1, 4, 1, 5];
        Array.Sort(nums);

        Console.WriteLine($"{nums}");
    }
}