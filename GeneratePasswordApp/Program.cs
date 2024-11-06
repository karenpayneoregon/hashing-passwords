

using PasswordGenerator;

namespace GeneratePasswordApp;
internal partial class Program
{
    static async Task Main(string[] args)
    {
        await Setup();

        var pwd = new Password(24)
            .IncludeNumeric()
            .IncludeLowercase()
            .IncludeUppercase()
            .IncludeSpecial();


        AnsiConsole.MarkupLine($"[white]Length 24[/]");
        for (int index = 0; index < 10; index++)
        {
            AnsiConsole.MarkupLine($"[cyan]{index,-4}[/][darkorange3]{pwd.Next()}[/]");
        }

        Console.WriteLine();

        pwd = new Password(12)
            .IncludeNumeric()
            .IncludeLowercase()
            .IncludeUppercase()
            .IncludeSpecial();

        AnsiConsole.MarkupLine($"[white]Length 12[/]");
        for (int index = 0; index < 10; index++)
        {
            AnsiConsole.MarkupLine($"[cyan]{index,-4}[/][darkorange3]{pwd.Next()}[/]");
        }

        ExitPrompt();
    }
}