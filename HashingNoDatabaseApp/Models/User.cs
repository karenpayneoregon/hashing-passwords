namespace HashingNoDatabaseApp.Models;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string HashedPassword { get; set; }
}