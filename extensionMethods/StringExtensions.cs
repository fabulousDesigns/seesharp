using System.Globalization;

public static class StringExtensions
{
    public static bool IsPalindrome(this string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        var reversed = new string(input.Reverse().ToArray());
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    public static string ToCurrency(this decimal value)
    {
        return value.ToString("C2", new CultureInfo("sw-KE"));
    }

    public static string ToSentenceCase(this string input)
    {
        return input.ToLower().First().ToString().ToUpper() + input.Substring(1);
    }

    public static void Log<T>(this IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}