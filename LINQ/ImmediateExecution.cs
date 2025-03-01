class ImmediateExecution
{
  public void immediateExecution()
  {
    var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   // Query executes immediately, results stored in memory
    var query = numbers.Where(n => n > 5).ToList();
    numbers.Add(11); // Won't affect 'query' because it's already materialized
    foreach (var num in query)
    {
      Console.WriteLine(num);
    }
    //🔹 Since we used ToList(), the query executed immediately, freezing the results.
   // Immediate Execution with Count()
   var numbersCount = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   var count = numbersCount.Count(n => n > 5); // Executes immediately
   Console.WriteLine($"Count: {count}");
   // Immediate Execution with First()
   var numbersFirst = new List<int> { 3, 6, 9, 12 };
   var first = numbers.First(n => n % 2 == 0); // Executes immediately
   Console.WriteLine($"First even number: {first}");

  }
}