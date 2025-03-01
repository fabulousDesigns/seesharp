class Counter
{
    private int _count;
    private readonly object _lockObj = new object();

    public void Increment()
    {
        lock (_lockObj) // Prevents multiple threads from entering
        {
            _count++;
            Console.WriteLine($"Count: {_count}");
        }
    }
}