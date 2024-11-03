using EF_Core_ValueConversionsEncryptProperty.Models;
using EntityCoreFileLogger;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static ConfigurationLibrary.Classes.ConfigurationHelper;
//using static ValueConversionsEncryptProperty.Classes.SecurityHelpers;

namespace EF_Core_ValueConversionsEncryptProperty.Data;

public class Context : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Property(e => e.Password).HasConversion(
            v => BC.HashPassword(v),
            v => v);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .LogTo(new DbContextToFileLogger().Log,
                [DbLoggerCategory.Database.Command.Name],
                LogLevel.Information)
            .UseSqlServer(ConnectionString())
            .EnableSensitiveDataLogging();
}