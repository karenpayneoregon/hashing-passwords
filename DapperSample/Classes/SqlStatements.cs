namespace DapperSample.Classes;
internal class SqlStatements
{
    public static string GetUser => 
        """
        SELECT Id
            ,[Name]
            ,[Password]
        FROM [dbo].[User]
        WHERE [Name] = @UserName
        """;
}
