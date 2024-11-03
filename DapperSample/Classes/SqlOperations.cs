using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;
using DapperSample.Classes.Configuration;
using DapperSample.Models;

namespace DapperSample.Classes;
internal class SqlOperations
{
    private IDbConnection _cn = new SqlConnection(DataConnections.Instance.MainConnection);
    public User Get(string userName)
        => _cn.QueryFirstOrDefault<User>(SqlStatements.GetUser, new { UserName = userName });


}
