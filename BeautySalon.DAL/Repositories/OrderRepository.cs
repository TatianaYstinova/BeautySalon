using System.Data;
using BeautySalon.DAL.DTO;
using BeautySalon.DAL.IRepositories;
using BeautySalon.DAL.StoredProcedures;
using Microsoft.Data.SqlClient;
using Dapper;

namespace BeautySalon.DAL.Repositories;

public class OrderRepository: IOrderRepository
{
    public List<OrdersDTO> RemoveOrderForClientByOrderId(int orderId)
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameters = new { OrderId = orderId };
            return connection.Query<OrdersDTO>(Procedures.RemoveOrderForClientByOrderId, parameters).ToList();
        }
    }
    public List<UpdateOrderTimeForClientByIdDto> UpdateOrderTimeForClientById(int orderId, int clientId, int masterId, int intervalId)
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameters = new {OrderId = orderId, ClientId = clientId, MasterId = masterId, IntervalId = intervalId };
            return connection.Query<UpdateOrderTimeForClientByIdDto>(Procedures.UpdateOrderTimeForClientById, parameters).ToList();
        }
    }
}