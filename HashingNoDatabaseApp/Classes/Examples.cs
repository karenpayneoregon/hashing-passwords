namespace HashingNoDatabaseApp.Classes;
internal class Examples
{
    /// <summary>
    /// Authenticates a user by verifying the entered password against the stored hashed password.
    /// In this case the password is correct.
    /// </summary>
    /// <remarks>
    /// This method retrieves user data from a mocked data source, compares the entered password
    /// with the stored hashed password using BCrypt, and prints the authentication result.
    /// </remarks>
    public static void AuthenticateUser()
    {

        PrintCyan();

        // The user enters their username and password
        var userEnteredName = "John";
        var password = "!john@Coffee*Today";

        var user = MockedData.Deserialize().FirstOrDefault(x => x.Username == userEnteredName);
        if (user != null)
        {
            var isAuthenticated = BC.EnhancedVerify(password, user.HashedPassword);
            Console.WriteLine(isAuthenticated ? "Authenticated" : "Not authenticated");
        }
        else
        {
            Console.WriteLine("User does not exist");
        }
    }
    /// <summary>
    /// Attempts to authenticate a user by verifying the entered password against the stored hashed password.
    /// In this case, the password is incorrect.
    /// </summary>
    /// <remarks>
    /// This method retrieves user data from a mocked data source, compares the entered password
    /// with the stored hashed password using BCrypt, and prints the authentication result.
    /// </remarks>
    public static void NotAuthenticateUser()
    {

        PrintCyan();

        // The user enters their username and password
        var userEnteredName = "John";
        var password = "@john@Coffee*Today";

        var user = MockedData.Deserialize().FirstOrDefault(x => x.Username == userEnteredName);
        if (user != null)
        {
            var isAuthenticated = BC.EnhancedVerify(password, user.HashedPassword);
            Console.WriteLine(isAuthenticated ? "Authenticated" : "Not authenticated");
        }
        else
        {
            Console.WriteLine("User does not exist");
        }
    }


}
