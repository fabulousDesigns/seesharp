public class UserService
{
    public string GetUserSummary(User? user)
    {
        
        // Return a summary of user info
        // Handle all possible null cases
        // If user is null, return "No user provided"
        // If email is null, use "No email"
        // If address is null, use "No address"
        
        if (user == null)
        {
            return "No user Provided";
        }
        
        // Null coalescing operator(??)
        var name = user?.Name ?? "No name";
        var email = user?.Email ?? "No Email";
        
        // Null-conditional operator (?.) with null-coalescing

        var city = user?.Address?.City ?? "No city";

        return $"Name: {name}, Email: {email}, City: {city}";

    }


    static void Main()
    {
        UserService userService = new UserService();
        User user = new User { Name = "Po", Email = null, Address = null };
        Console.WriteLine($"Skadoosh, {userService.GetUserSummary(user)}");
    }
}