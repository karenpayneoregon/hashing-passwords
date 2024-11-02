using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Data;
using RazorPagesSample.Interfaces;
using RazorPagesSample.Models;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

// ReSharper disable ConvertConstructorToMemberInitializers
#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace RazorPagesSample.Pages;
public class IndexModel(Context context, IAuthentication authentication) : PageModel
{
    public void OnGet()
    {
        CurrentUser = new User() { Name = "Karen", Password = "password" };
    }

    // Set user to an existing record in the database
    [BindProperty]
    public User CurrentUser { get; set; }

    /// <summary>
    /// Text to show for authentication status
    /// </summary>
    public string Message { get; set; } = "";

    /// <summary>
    /// Validates the current user by checking the provided password against the stored password in the database.
    /// Authentication
    /// </summary>
    /// <remarks>
    /// This method uses the BCrypt library to verify the password and logs the authentication result.
    /// </remarks>
    public void OnPostValidateUser()
    {

        var (authenticated, id) = authentication.ValidateUser(CurrentUser!, context);

        Log.Information(authenticated ?
            "{Id,-3} User {Name} authenticated" :
            "User {Name} not authenticated", id,CurrentUser.Name);

        Message = authenticated ? "Authenticated" : "Not authenticated";
    }

}
