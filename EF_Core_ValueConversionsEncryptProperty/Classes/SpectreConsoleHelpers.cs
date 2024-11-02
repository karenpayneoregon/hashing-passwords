using System.Runtime.CompilerServices;

namespace EF_Core_ValueConversionsEncryptProperty.Classes;
public class SpectreConsoleHelpers
{
    public static void ExitPrompt()
    {
        Console.WriteLine();

        Render(new Rule($"[yellow]Press[/] [cyan]ENTER[/] [yellow]to exit the demo[/]")
            .RuleStyle(Style.Parse("silver")).Centered());

        Console.ReadLine();
    }
    public static void PrintDeepBlue([CallerMemberName] string? methodName = null)
    {
        AnsiConsole.MarkupLine($"[deepskyblue1]{methodName}[/]");
    }
    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }
}
