using System.Data.SqlClient;
using APBD_6.Models;

namespace APBD_6.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IConfiguration _configuration;

    public WarehouseService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void AddProduct(ProductWarehouse productWarehouse)
    {
        var connectionString = _configuration.GetConnectionString("Database");
        using var connection = new SqlConnection(connectionString);
        using var cmd = new SqlCommand();

        cmd.Connection = connection;

           
    }
}