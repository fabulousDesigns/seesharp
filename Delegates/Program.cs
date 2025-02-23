public delegate void myDelegate(string msg);


class Program
{
    public static void MethodOne(string msg)
    {
        Console.WriteLine($"MethodOne received: {msg}");
    }

    public static void MethodTwo(string msg)
    {
        Console.WriteLine($"MethodTwo received: {msg}");
    }


    static void Main()
    {
        myDelegate del;
        del = MethodOne;
        del += MethodTwo;
        
        del("Hello, Multicast Delegates!");
        
        del -= MethodOne;
        
        Console.WriteLine("\nAfter removing MethodOne:");

        del("Hello again!");
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(10));
        
        Func<int, int ,int > add = (a, b) => a + b;
        Console.WriteLine(add(10, 20)); // Output: 30
        
        Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
        greet("Bernard"); // Output: Hello, Bernard!

        Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
        printSum(10, 70);
        Predicate<int> isEven = num => num % 2 == 0;
        Console.WriteLine(isEven(4)); // Output: True
        Console.WriteLine(isEven(7)); // Output: False
        
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Predicate<int> IsEven = num => num % 2 == 0;
        List<int> evens = numbers.FindAll(IsEven);

        Console.WriteLine(string.Join(", ", evens)); // Output: 2, 4, 6, 8, 10
    }
}

