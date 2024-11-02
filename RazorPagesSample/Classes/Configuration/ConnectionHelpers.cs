using System.Diagnostics;
using ConfigurationLibrary.Classes;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesSample.Classes.Configuration;

internal class ConnectionHelpers
{
    public static void StandardLoggingSqlServer(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(ConfigurationHelper.ConnectionString())
            .EnableSensitiveDataLogging()
            .LogTo(message => Debug.WriteLine(message));

    }
}