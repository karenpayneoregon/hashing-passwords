using EF_Core_ValueConversionsEncryptProperty.Classes;
using static EF_Core_ValueConversionsEncryptProperty.Classes.SpectreConsoleHelpers;

namespace EF_Core_ValueConversionsEncryptProperty;

internal partial class Program
{
    private static async Task Main(string[] args)
    {

        await Examples.CreateDatabase();
        Console.WriteLine();
        await Examples.AuthenticateUser();
        Console.WriteLine();
        await Examples.NotAuthenticateUser();

        ExitPrompt();
    }
}