
using Bogus;
using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using NetDevPack.Security.PasswordHasher.Argon2;
using NetDevPack.Security.PasswordHasher.Core;
using NetDevPackHasherArgonApp.Classes;
using NetDevPackHasherArgonApp.Models;

namespace NetDevPackHasherArgonApp;
internal partial class Program
{
    private static Faker _faker;

    static async Task Main(string[] args)
    {
        await Setup();

        var testUser = UserEntersCredentials();
        AnsiConsole.MarkupLine($"[cyan]       Password[/] [yellow]{testUser.Password}[/]");
        AnsiConsole.MarkupLine($"[cyan]Hashed password[/] [yellow]{testUser.HashPassword}[/]");

        /*
         *  Verify the hashed password and print the result to the console using NuGet package FluentAssertions.
        */
        var valid = testUser.Argon2Id.VerifyHashedPassword(testUser.GenericUser, testUser.HashPassword, testUser.Password)
            .Should().Be(PasswordVerificationResult.Success);

        AnsiConsole.MarkupLine(valid.And.Subject == PasswordVerificationResult.Success
            ? "   [green]Password is correct[/]"
            : "   [red]Password is incorrect[/]");

        ExitPrompt();
    }

    /// <summary>
    /// Generates a password, hashes it using Argon2, and returns a <see cref="User"/> object containing the user details and hashed password.
    /// For a real application prompts are needed to get username and password. See the readme file for how to prompt for user input.
    /// </summary>
    /// <returns>A <see cref="User"/> object containing the generated user, plain text password, hashed password, and Argon2 hasher.</returns>
    private static User UserEntersCredentials()
    {
        var passwordHasher = new PasswordHasher<GenericUser>();
        var options = Options.Create(new ImprovedPasswordHasherOptions()
        {
            Strength = PasswordHasherStrength.Sensitive
        });

        _faker = new Faker();

        var password = _faker.Internet.Password();
        var user = GenericUserFaker.GenerateUser().Generate();
        var argon2Hasher = new Argon2Id<GenericUser>(passwordHasher, options);

        var hashedPass = argon2Hasher.HashPassword(user, password);

        return new User()
        {
            GenericUser = user,
            Password = password,
            HashPassword = hashedPass,
            Argon2Id = argon2Hasher
        };
    }
}