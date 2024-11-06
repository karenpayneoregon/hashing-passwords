using Bogus;
using NetDevPackHasherArgonApp.Models;

namespace NetDevPackHasherArgonApp.Classes;

/// <summary>
/// Provides functionality to generate fake instances of <see cref="GenericUser"/> using the Bogus library.
/// </summary>
public class GenericUserFaker
{
    public static Faker<GenericUser> GenerateUser() => new();
}