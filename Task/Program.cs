class Program
{
    static async Task Main()
    {
        // Creating A task
        //✅ Task.Run() automatically manages thread scheduling and execution.
        
        Task.Run(() =>
        {
            Console.WriteLine("Running a Task");
        });
        // ✅ Waiting for a Task (Task.Wait())
        Task task = Task.Run(() => Console.Write("Task Running"));
        task.Wait(); // ✅ Wait() is a blocking call; use await instead in async programming
        
        // ✅ Returning Results from a Task
        Task<int> task2 = Task.Run(() =>
        {
            Thread.Sleep(2000);
            return 42;
        });

        Console.WriteLine($"Result: {task2.Result}");
        // ✅ task.Result blocks the thread; use await for better performance.
        
        // ✅ async and await (Best for Async Operations)
        // async Task<int> FetchDataAsync()
        // {
        //     await Task.Delay(2000); // Simulate work
        //     return 100;
        // }

     //   int result = await FetchDataAsync();
      //  Console.WriteLine($"Data: {result}");
        
        
        // ✅ Parallel.For and Parallel.ForEach (Multiple Tasks in Parallel)
        

        Parallel.For(1, 6, i =>
        {
            Console.WriteLine($"Processing {i}");
        });
        
        string[] names = { "Alice", "Bob", "Charlie" };
        Parallel.ForEach(names, name =>
        {
            Console.WriteLine($"Processing {name}");
        });


    }
}