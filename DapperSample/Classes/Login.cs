namespace DapperSample.Classes;

internal class Login
{
    public static void DrawHeader()
    {
        Render(
            new Rule()
                .RuleStyle(Style.Parse("green"))
                .HeavyBorder()
                .LeftJustified());

        AnsiConsole.Write(new FigletText("Enter credentials").Centered().Color(Color.Green));

        Render(
            new Rule()
                .RuleStyle(Style.Parse("green"))
                .HeavyBorder()
                .LeftJustified());
    }

    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }
    public static string AskLoginName()
    {
        return AnsiConsole.Prompt(
            new TextPrompt<string>("[thistle1]User name[/]?")
                .DefaultValue("Karen")
                .PromptStyle("grey50"));
    }

    public static string AskPassword()
    {
        return AnsiConsole.Prompt(
            new TextPrompt<string>("[thistle1] Password[/]?")
                .DefaultValue("password")
                .PromptStyle("grey50"));
    }
}