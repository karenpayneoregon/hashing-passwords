using RazorPagesSample.Data;
using RazorPagesSample.Models;

namespace RazorPagesSample.Interfaces;

/// <summary>
/// Defines methods for authenticating users within the application.
/// </summary>
public interface IAuthentication
{
    /// <summary>
    /// Validates the specified user against the provided context.
    /// </summary>
    /// <param name="user">The user to validate, containing user credentials.</param>
    /// <param name="context">The database context used to retrieve user information.</param>
    /// <returns>
    /// A tuple where the first element indicates whether the user is valid, 
    /// and the second element is the user's ID if validation is successful, or -1 if not.
    /// </returns>
    (bool, int) ValidateUser(User user, Context context);
}