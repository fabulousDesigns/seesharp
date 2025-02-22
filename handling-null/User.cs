public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Address? Address { get; set; }  // Notice the ? making it nullable
}