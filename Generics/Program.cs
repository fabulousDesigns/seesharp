var numberPair = new Pair<int>(10, 20);
// Console.WriteLine($"First: {numberPair.GetFirst()}, Second: {numberPair.GetSecond()}"); // 10, 20
numberPair.Swap();
// Console.WriteLine($"After swap - First: {numberPair.GetFirst()}, Second: {numberPair.GetSecond()}"); // 20, 10

// var stringPair = new Pair<string>("Hello", "World");
// stringPair.SetFirst("Hi");
// Console.WriteLine($"First: {stringPair.GetFirst()}, Second: {stringPair.GetSecond()}"); // Hi, World

// var digits = new Calculator<int>();

// Console.WriteLine("Maximum:" + digits.Max(20, 5));
// Console.WriteLine("Minimum:" + digits.Min(20, 5));
// Console.WriteLine("Add:" + digits.Add(20, 5));
// Console.WriteLine("Subtract:" + digits.Subtract(20, 5));

// var utils = new Utilities();
int a = 5, b = 10;
// Console.WriteLine($"Before swap: a = {a}, b = {b}");
// utils.Swap(ref a, ref b);
// Console.WriteLine($"After swap: a = {a}, b = {b}");
//
// string[] names = ["John", "Jane", "Bob"];
//
// utils.PrintArray(names);
//
// int[] numbers = { 1, 2, 3, 4, 5 };
// int index = utils.Find(numbers, 3);
// Console.WriteLine($"Found 3 at index: {index}");

var generics = new Generics();
generics.Swap(ref a, ref b);
// Console.WriteLine($"{a}, {b}");
List<string> names = new() { "Alice", "Bob", "Charlie" };
generics.PrintElements(names);

var showMaxValue = generics.GetMax(a, b);
Console.WriteLine($"Max Value is {showMaxValue}");
Console.WriteLine(generics.GetMax("Apple", "Banana"));


