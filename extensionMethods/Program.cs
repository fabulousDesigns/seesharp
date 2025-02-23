class Program
{
    static void Main()
    {
        string word = "Madam";
        bool isPalindrome = word.IsPalindrome(); // true

        Console.WriteLine($"{isPalindrome}");

        decimal price = 99.99m;
        Console.WriteLine(price.ToCurrency());

        string text = "hello world";
        string sentence = text.ToSentenceCase();

        Console.WriteLine(sentence);
        
        List<int> numbers = new List<int> { 1, 2, 3 };
        
        numbers.Log();
    }
}