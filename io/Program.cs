using System.Text.Json;

class Program
{
    static void Main()
    {
        // Create, Delete, and Check Directories
        // const string path = @"C:\source\io";
        // // create Directory
        // if (!Directory.Exists(path))
        // {
        //     Directory.CreateDirectory(path);
        // }
        //
        // // Delete Directory
        // if (Directory.Exists(path))
        // {
        //     Directory.Delete(path, recursive: true);
        // }
        
        // Get Files in a Directory
        // string[] files = Directory.GetFiles(@"C:\Windows");
        // foreach (var file in files)
        // {
        //     Console.WriteLine(file);
        // }
        
        // string filePath = @"C:\MyFolder\test.txt";
        // File.WriteAllText(filePath, "Hello, Bernard!"); // Overwrites content
        // File.AppendAllText(filePath, "\nThis is an appended line!"); // Appends content
        // if (File.Exists(filePath))
        // {
        //     string content = File.ReadAllText(filePath);
        //     Console.WriteLine(content);
        // }
        
        // Writing
//         using (StreamWriter writer = new StreamWriter(filePath))
//         {
//             writer.WriteLine("Line 1");
//             writer.WriteLine("Line 2");
//         }
//
// // Reading
//         using (StreamReader reader = new StreamReader(filePath))
//         {
//             string line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 Console.WriteLine(line);
//             }
//         }
        Person person = new Person { Name = "Bernard", Age = 25 };

// Serialize to JSON
        string json = JsonSerializer.Serialize(person);
        Console.WriteLine(json);

// Deserialize JSON back to object
        Person deserialized = JsonSerializer.Deserialize<Person>(json);
       // Console.WriteLine($"Name: {deserialized.Name}, Age: {deserialized.Age}");

    }
}




