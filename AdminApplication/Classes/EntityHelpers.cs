using AdminApplication.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace AdminApplication.Classes;
internal class EntityHelpers
{
    public static bool DatabaseExists()
    {
        using var context = new Context();
        return ((context.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator)!).Exists();
    }
}
