using Npgsql;

namespace Infrastructure.Data;

public class DapperContext
{
    private readonly string connectionString = "Server = localhost;Port = 5432;Database = CompanyDb;Username = postgres;Password = 7070";

    public NpgsqlConnection Connection
    {
        get
        {
            return new NpgsqlConnection(connectionString); 
            
        }
    }
}