using System.Runtime.CompilerServices;
using EF_Core_ValueConversionsEncryptProperty.Classes;


// ReSharper disable once CheckNamespace
namespace EF_Core_ValueConversionsEncryptProperty;

internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        SetupLogging.Development();
    }
}