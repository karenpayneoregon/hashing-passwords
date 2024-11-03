using AdminApplication.Models;
using EntityCoreFileLogger;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static AdminApplication.Classes.Configuration.DataConnections;

namespace AdminApplication.Data;

public class Context : DbContext
{
    public virtual DbSet<User> User { get; set; }
    /// <summary>
    /// Configures the model that is being built for this context.
    /// Note use of HasConversion to encrypt the password property.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Property(e => e.Password).HasConversion(
            v => BC.HashPassword(v),
            v => v);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .LogTo(new DbContextToFileLogger().Log,
                [DbLoggerCategory.Database.Command.Name],
                LogLevel.Information)
            .UseSqlServer(Instance.MainConnection)
            .EnableSensitiveDataLogging();
    }
}