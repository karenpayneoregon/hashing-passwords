using DapperSample.Classes;


namespace DapperSample;
internal partial class Program
{
    static async Task Main(string[] args)
    {
        await Setup();

        Login.DrawHeader();

        var userName = Login.AskLoginName();
        var password = Login.AskPassword();

        SqlOperations operations = new();
        var user = operations.Get(userName);

        if (user is not null)
        {
            var verified = BC.Verify(password, user.Password);

            AnsiConsole.MarkupLine(verified ?
                "   [green]Password is correct[/]" :
                "   [red]Password is incorrect[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]User not found[/]");
        }


        ExitPrompt();
    }
}