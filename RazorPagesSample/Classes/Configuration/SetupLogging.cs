using Serilog.Events;
using SeriLogThemesLibrary;

namespace RazorPagesSample.Classes.Configuration;
/// <summary>
/// For setting up SeriLog to keep Program.Main clean and allows code to be easily copied to other projects.
/// </summary>
public class SetupLogging
{

    /// <summary>
    /// Configures Serilog for development environment logging.
    /// </summary>
    /// <remarks>
    /// This method sets up Serilog to log messages to the console with a custom theme and overrides the minimum log level for Microsoft namespaces to Information.
    /// </remarks>
    public static void Development()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .WriteTo.Console(theme: SeriLogCustomThemes.Default())
            .CreateLogger();
    }
}


