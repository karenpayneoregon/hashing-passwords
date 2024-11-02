using HashingNoDatabaseApp.Classes;

namespace HashingNoDatabaseApp;
internal partial class Program
{
    static async Task Main(string[] args)
    {
        await Setup();
        Examples.AuthenticateUser();
        Console.WriteLine();
        Examples.NotAuthenticateUser();
        ExitPrompt();
    }
}