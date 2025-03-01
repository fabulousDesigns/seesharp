using System;

class Program
{
    // 1️⃣ Define a Delegate
    public delegate void Notify(); 

    // 2️⃣ Define a Publisher Class
    class Process
    {
        public event Notify ProcessCompleted; // Declare an Event

        public void Start()
        {
            Console.WriteLine("Process Started...");
            ProcessCompleted?.Invoke(); // Raise Event
        }
    }

    // 3️⃣ Define a Subscriber Method
    static void OnProcessCompleted()
    {
        Console.WriteLine("Process Completed Successfully!");
    }

    static void Main()
    {
        Process process = new Process(); // Create Publisher
        process.ProcessCompleted += OnProcessCompleted; // Subscribe to Event

        process.Start(); // Start Process (Raises Event)
    }
}