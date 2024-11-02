using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Data;
using RazorPagesSample.Models;
using Serilog;

// ReSharper disable ConvertConstructorToMemberInitializers
#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace RazorPagesSample.Pages;
public class IndexModel : PageModel
{
    public IndexModel() => Message = "";

    // Set user to an existing record in the database
    [BindProperty]
    public User? CurrentUser { get; set; } = new(id: 1, name: "Karen", password: "password");
    /// <summary>
    /// Text to show for authentication status
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Validates the current user by checking the provided password against the stored password in the database.
    /// </summary>
    /// <remarks>
    /// This method uses the BCrypt library to verify the password and logs the authentication result.
    /// </remarks>
    public void OnPostValidateUser()
    {
        using var context = new Context();
        var user = context.Users.FirstOrDefault();

        var isAuthenticated = BC.Verify(CurrentUser.Password, user.Password);
        Log.Information(isAuthenticated ? 
            "User {Name} authenticated" : 
            "User {Name} not authenticated", user.Name);

        Message = isAuthenticated ? "Authenticated" : "Not authenticated";
    }

}
