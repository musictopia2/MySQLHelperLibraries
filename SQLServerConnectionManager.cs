
namespace MySQLHelperLibraries;
public class SQLServerConnectionManager : IDatabaseConnectionManager
{
    EnumDatabaseCategory IDatabaseConnectionManager.PrepareDatabase()
    {
        GlobalClass.MySQLConnector ??= new CustomMySQLConnectionClass();
        return EnumDatabaseCategory.SQLServer;
    }
}