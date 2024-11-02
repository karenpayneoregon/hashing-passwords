using System.Text.Json;
using HashingNoDatabaseApp.Models;

namespace HashingNoDatabaseApp.Classes;

public class MockedData
{
    public static List<User> Users =>
    [
        new User { Username = "Duke", Password = "!duke@Coffee*Today" },
        new User { Username = "John", Password = "!john@Coffee*Today" },
        new User { Username = "Jane", Password = "!jane@Coffee*Today" }
    ];

    public static List<User> Secure()
    {
        List<User> users = Users;
        foreach (var user in users)
        {
            user.HashedPassword = BC.EnhancedHashPassword(user.Password, 13);
        }
        return users;
    }

    public static void Serialize()
    {
        var secureUsers = Secure();
        var json = JsonSerializer.Serialize(secureUsers, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("secureUsers.json", json);
    }
    public static List<User> Deserialize()
    {
        var json = File.ReadAllText("secureUsers.json");
        return JsonSerializer.Deserialize<List<User>>(json);
    }
}