using BeautySalon.DAL.DTO;

namespace BeautySalon.DAL.IRepositories;

public interface IOrderRepository
{
    public List<GetOrdersByMasterId> GetOrdersByMasterId(int id);
    
    public void RemoveOrderForClientByOrderId(int orderId);
    
    public List<GetAllOrdersOnTodayForMastersDTO> GetAllOrdersOnTodayForMasters();
    public List<OrdersByClientIdDTO> GetOrderByClientId(int clientid);

    public void UpdateOrderTimeForClientById(int orderId, int clientId,int masterId,int intervalId);
    public void CreateNewOrder (int clientId, int masterId, DateTime data, int serviceId, int intervalId);
}