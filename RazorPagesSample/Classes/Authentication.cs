using RazorPagesSample.Data;
using RazorPagesSample.Interfaces;
using RazorPagesSample.Models;

namespace RazorPagesSample.Classes;

/// <summary>
/// Provides authentication services for validating users within the application.
/// Currently only one method.
/// </summary>
public class Authentication : IAuthentication
{
    /// <summary>
    /// Validates the specified user by comparing the provided password with the stored password in the database.
    /// </summary>
    /// <param name="user">The user object containing the credentials to validate.</param>
    /// <param name="context">The database context used to access the stored user data.</param>
    /// <returns>
    /// A tuple containing a boolean and an integer:
    /// <list type="bullet">
    /// <item>
    /// <description><c>true</c> if the provided password matches the stored password for the user; otherwise, <c>false</c>.</description>
    /// </item>
    /// <item>
    /// <description>The user's ID if the password matches; otherwise, -1.</description>
    /// </item>
    /// </list>
    /// </returns>
    /// <remarks>
    /// This method utilizes the BCrypt library to verify the password and logs the result of the authentication attempt.
    /// </remarks>      
    public (bool, int) ValidateUser(User user, Context context)
    {
        var current = context.Users.FirstOrDefault(x => x.Name == user.Name);
        return current is null ? 
            (false, -1) : 
            (BC.Verify(user.Password, current.Password), current.Id);
    }
}