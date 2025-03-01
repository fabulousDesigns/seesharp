class DeferredExecution
{
  public void deferredExexcution()
  {
    int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    var evenNumbers = numbers.Where(n => n % 2 == 0);
    Console.WriteLine("Query Created, but not yet Executed");

    foreach (var even in evenNumbers)
    {
      Console.WriteLine(evenNumbers);
    }
     // 🔹 The query does not execute until foreach starts iterating.
    //  🔥 Key Takeaways for Deferred Execution:
    //  ✅ Query is not executed when declared.
    //  ✅ Query executes each time it is accessed.
   //   ✅ If the data source changes before execution, the query results change.
    
  }
}