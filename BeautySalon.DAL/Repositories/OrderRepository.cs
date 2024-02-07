using System.Data;
using BeautySalon.DAL.DTO;
using BeautySalon.DAL.IRepositories;
using BeautySalon.DAL.StoredProcedures;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Intrinsics.X86;

namespace BeautySalon.DAL.Repositories;

public class OrderRepository : IOrderRepository
{
    //не пашет
    // public List<GetMastersOrdersByIdDTO> GetMastersOrdersById(int id)
    // {
    //     using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
    //     {
    //         var parameters = new { Id = id };
    //         return connection.Query<GetMastersOrdersByIdDTO,UsersDTO,IntеrvalsDTO,ServicesDTO,UsersDTO,GetMastersOrdersByIdDTO>(Procedures.GetMastersOrdersById,
    //                 (orders,master,intervals,services,clients)=>
    //                 {
    //                     if (orders.Services == null)
    //                     {
    //                         orders.Services = new List<ServicesDTO>();
    //                     }
    //
    //                     if (orders.Master == null)
    //                     {
    //                         orders.Master = new List<UsersDTO>();
    //                     }
    //
    //                     if (orders.Client == null)
    //                     {
    //                         orders.Client = new List<UsersDTO>();
    //                     }
    //
    //                     if (orders.Intervals == null)
    //                     {
    //                         orders.Intervals = new List<IntеrvalsDTO>();
    //                     }
    //                 
    //                     orders.Master.Add(master);
    //                     orders.Intervals.Add(intervals);
    //                     orders.Services.Add(services);
    //                     orders.Client.Add(clients);
    //                     return orders;
    //                 },parameters,splitOn:"Id,MasterId,StartIntervalId,ServiceId,ClientId")
    //             .ToList();
    //     }
    // }

    public List<GetOrdersByMasterId> GetOrdersByMasterId(int id)
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameters = new { Id = id };
            return connection.Query<UsersDTO,GetOrdersByMasterId,ServicesDTO,UsersDTO,GetOrdersByMasterId>(Procedures.GetOrdersByMasterId,
                    (master,order,service,client)=>
                    {
                        order.Master = master;
                        order.Services = service;
                        order.Client = client;
                        return order;
                    },parameters,splitOn:"Id")
                .ToList();
        } 
    }

    public List<GetAllOrdersOnTodayForMastersDTO> GetAllOrdersOnTodayForMasters()
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            return connection.Query<GetAllOrdersOnTodayForMastersDTO,UsersDTO,ServicesDTO,IntеrvalsDTO,UsersDTO, GetAllOrdersOnTodayForMastersDTO>(Procedures.GetAllOrdersOnTodayForMasters,
                    (order,master,service, intervals,client)=>
                    {
                        if (order.Master == null)
                        {
                            order.Master = new List<UsersDTO>();
                        }
                        order.Master.Add(master);
                        if (order.Services == null)
                        {
                            order.Services = new List<ServicesDTO>();
                        }
                        order.Services.Add(service); 
                        if (order.Intervals == null)
                        {
                            order.Intervals = new List<IntеrvalsDTO>();
                        }
                        order.Intervals.Add(intervals);
                        if (order.Client == null)
                        {
                            order.Client = new List<UsersDTO>();
                        }
                        order.Client.Add(client);
                        return order;
                    },splitOn:"Id,Title,Title,Name")
                .ToList();
        } 
    }
    public List<OrdersByClientIdDTO> GetOrdersByClientId (int clientid)
    {

        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameter = new
            {
                UserId = clientid,
            };

            return connection.Query<UsersDTO, OrdersByClientIdDTO, ServicesDTO, OrdersByClientIdDTO>
                 (
                     Procedures.GetOrderInfo,
                     (master, order, service) =>
                     {
                         Console.Write(service.ServiceId);

                         order.Master = master;
                         order.Services = service;

                         return order;
                     },
                     parameter, 
                     splitOn:"MasterName,OrderId,ServiceId"
                 ).ToList();

            
        }
    }
    public void UpdateOrderTimeForClientById(int orderId, int clientId, int masterId, int intervalId)
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameters = new
            {
                OrderId = orderId,
                ClientId = clientId,
                MasterId = masterId,
                IntervalId = intervalId
            };
            connection.Query(Procedures.UpdateOrderTimeForClientById, parameters).ToList();
        }
    }
    public void  RemoveOrderForClientByOrderId (int orderId)
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameters = new
            {
                OrderId = orderId
            };
              connection.Query<OrdersDTO>(Procedures.RemoveOrderForClientByOrderId, parameters);
        }
    }
    public void CreateNewOrder(int clientId, int masterId, DateTime date, int serviceId, int intervalId)
    {
        using (IDbConnection connection = new SqlConnection(Options.ConnectionString))
        {
            var parameters = new
            {
                ClientId = clientId,
                MasterId = masterId,
                Date = date,
                ServiceId = serviceId,
                IntervalId = intervalId
            };
            
            connection.Query<OrdersDTO>(Procedures.CreateNewOrder, parameters);
        }
    }
}