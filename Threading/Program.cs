class Program
{
    static void Main()
    {
        void printNumbers()
        {
            for (var i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread: {i}");
              //  Thread.Sleep(1000);
            }
        }

        Thread t1 = new Thread(printNumbers);
        t1.Start();
        
        // Passing params to threads: ✅ Use object parameters, but avoid boxing/unboxing by using ParameterizedThreadStart

        void PrintMessage(object message)
        {
            Console.WriteLine($"Message: {message}");
        }

        Thread t2 = new Thread(PrintMessage);
        t2.Start("Hello from C# Threads");
        
        //  2.3 Foreground vs Background Threads
        //  Foreground Threads (default) keep the app running even if Main() exits
        //  Background Threads exit when Main() ends.

        // Thread t3 = new Thread(printNumbers);
        // t3.IsBackground = true;
        // t3.Start();
        // ✅ lock(obj) ensures only one thread at a time can access count.
        
        Counter counter = new Counter();
        Thread t4 = new Thread(counter.Increment);
        Thread t5 = new Thread(counter.Increment);

        t4.Start();
        t5.Start();
    }
}


