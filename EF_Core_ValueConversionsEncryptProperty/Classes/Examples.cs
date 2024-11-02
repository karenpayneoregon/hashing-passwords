using EF_Core_ValueConversionsEncryptProperty.Data;
using EF_Core_ValueConversionsEncryptProperty.Models;
using static EF_Core_ValueConversionsEncryptProperty.Classes.SpectreConsoleHelpers;

namespace EF_Core_ValueConversionsEncryptProperty.Classes;

internal class Examples
{
    /// <summary>
    /// Asynchronously creates and initializes the database.
    /// </summary>
    /// <remarks>
    /// This method performs the following actions:
    /// <list type="bullet">
    /// <item><description>Creates a new database context.</description></item>
    /// <item><description>Cleans the existing database using <see cref="SetupDatabase.CleanDatabase"/>.</description></item>
    /// <item><description>Adds a new <see cref="User"/> entity with predefined values.</description></item>
    /// <item><description>Saves the changes to the database.</description></item>
    /// </list>
    /// </remarks>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public static async Task CreateDatabase()
    {
        PrintDeepBlue();

        await using var context = new Context();
        AnsiConsole.MarkupLine("   [cyan]Creating database[/]");
        SetupDatabase.CleanDatabase(context);
        context.Add(new User { Name = "Karen", Password = "password" });
        await context.SaveChangesAsync();
        AnsiConsole.MarkupLine("   [cyan]Database created with one entry[/]");
    }
    public static async Task AuthenticateUser()
    {
        PrintDeepBlue();

        await using Context context = new();
        AnsiConsole.MarkupLine("   [cyan]Read the entity back[/]");

        var user = context.Set<User>().Single();

        AnsiConsole.MarkupLine($"   User [cyan]{user.Name}[/] has password [cyan]'{user.Password}'[/]");

        var verified = BC.Verify("password", user.Password);
        AnsiConsole.MarkupLine(verified ?
            "   [green]Password is correct[/]" :
            "   [red]Password is incorrect[/]");

    }

    public static async Task NotAuthenticateUser()
    {
        
        PrintDeepBlue();

        await using Context context = new();
        AnsiConsole.MarkupLine("   [cyan]Read the entity back[/]");

        var user = context.Set<User>().Single();

        AnsiConsole.MarkupLine($"   User [cyan]{user.Name}[/] has password [cyan]'{user.Password}'[/]");

        var verified = BC.Verify("password1", user.Password);
        AnsiConsole.MarkupLine(verified ?
            "   [green]Password is correct[/]" :
            "   [red]Password is incorrect[/]");

    }
}
