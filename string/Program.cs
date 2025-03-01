class Program
{
    static void Main()
    {
        var text =  "  C# is Powerful!  ";
        Console.WriteLine(text.ToUpper());    // "  C# IS POWERFUL!  "
        Console.WriteLine(text.ToLower());    // "  c# is powerful!  "
        Console.WriteLine(text.Trim());       // "C# is Powerful!"
        Console.WriteLine(text.Replace("Powerful", "Amazing")); // "  C# is Amazing!  "
        Console.WriteLine(text.Contains("C#")); // True
        Console.WriteLine(text.StartsWith("C#")); // False (because of spaces)
        Console.WriteLine(text.EndsWith("!  "));  // True
        Console.WriteLine(text.IndexOf("C#"));  // 2
        Console.WriteLine(text.Substring(2, 2));  // "C#"


        // Creating DateTime Instances
        DateTime now = DateTime.Now;
        var utcNow = DateTime.UtcNow;

        Console.WriteLine($"{now}, {utcNow}");
        
        // Formatting Dates
        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss")); // 2025-02-28 14:30:00
        Console.WriteLine(now.ToString("MMMM dd, yyyy")); // February 28, 2025
        Console.WriteLine(now.ToString("dddd, dd MMMM yyyy")); // Friday, 28 February 2025
        
        DateTime future = now.AddDays(10);   // Add 10 days
        DateTime past = now.AddMonths(-1);   // Subtract 1 month
        TimeSpan duration = future - now;    // Time difference
        Console.WriteLine(duration.TotalDays); // 10.0
        
        // Math
        Console.WriteLine(Math.Abs(-10)); // 10
        Console.WriteLine(Math.Pow(2, 3)); // 8
        Console.WriteLine(Math.Sqrt(25)); // 5
        Console.WriteLine(Math.Max(10, 20)); // 20
        Console.WriteLine(Math.Min(10, 20)); // 10
        Console.WriteLine(Math.Round(4.567, 2)); // 4.57
        Console.WriteLine(Math.Floor(4.9)); // 4
        Console.WriteLine(Math.Ceiling(4.1)); // 5

        // 📌  Trigonometric Functions
        double angle = 45;
        double radians = angle * (Math.PI / 180); // Convert degrees to radians

        Console.WriteLine(Math.Sin(radians)); // 0.707
        Console.WriteLine(Math.Cos(radians)); // 0.707
        Console.WriteLine(Math.Tan(radians)); // 1.0
        Console.WriteLine(Math.Atan(1) * (180 / Math.PI)); // 45 degrees
        // 📌 3.3 Random Numbers
        Random rand = new Random();
        Console.WriteLine(rand.Next(1, 101)); // Random number between 1-100
        Console.WriteLine(rand.NextDouble()); // Random double between 0-1
        
    }
}