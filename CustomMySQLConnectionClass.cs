namespace MySQLHelperLibraries;
public class CustomMySQLConnectionClass : IMySQLConnector
{
    EnumDatabaseCategory IDbConnector.GetCategory(IDbConnection connection)
    {
        if (connection is MySqlConnection == false)
        {
            throw new CustomBasicException("Should have been a mysql connection.  Rethink");
        }
        return EnumDatabaseCategory.MySQL;
    }
    IDbCommand IDbConnector.GetCommand()
    {
        return new MySqlCommand();
    }
    IDbConnection IDbConnector.GetConnection(EnumDatabaseCategory category, string connectionString)
    {
        if (category != EnumDatabaseCategory.MySQL)
        {
            throw new CustomBasicException("Only MySQL is supported for this category.  Rethink");
        }
        return new MySqlConnection(connectionString);
    }
    DbParameter IDbConnector.GetParameter()
    {
        return new MySqlParameter();
    }
}