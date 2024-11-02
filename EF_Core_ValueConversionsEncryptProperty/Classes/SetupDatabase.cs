using Microsoft.EntityFrameworkCore;

namespace EF_Core_ValueConversionsEncryptProperty.Classes;

internal class SetupDatabase
{

    public static void CleanDatabase(DbContext context)
    {

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

    }

}