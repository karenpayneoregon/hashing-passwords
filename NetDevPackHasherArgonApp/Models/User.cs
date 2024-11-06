using NetDevPack.Security.PasswordHasher.Argon2;

namespace NetDevPackHasherArgonApp.Models;

/// <summary>
/// Represents a user, including properties for password hashing using Argon2.
/// </summary>
public class User
{
    /// <summary>
    /// Gets or sets the Argon2Id password hasher for the <see cref="GenericUser"/>.
    /// This property is used to hash and verify passwords using the Argon2Id algorithm.
    /// </summary>
    public Argon2Id<GenericUser> Argon2Id { get; set; }
    /// <summary>
    /// Gets or sets the generic user associated with this instance.
    /// This property represents the user details that are used in conjunction with the Argon2Id password hasher.
    /// </summary>
    public GenericUser GenericUser { get; set; }
    /// <summary>
    /// Gets or sets the plain text password for the user.
    /// </summary>
    /// <remarks>
    /// This property holds the user's password in plain text. 
    /// It is used for password hashing and verification purposes.
    /// </remarks>
    public string Password { get; set; }
    /// <summary>
    /// Gets or sets the hashed password for the user.
    /// </summary>
    /// <value>
    /// A string representing the hashed password, generated using the Argon2 algorithm.
    /// </value>
    public string HashPassword { get; set; }

}