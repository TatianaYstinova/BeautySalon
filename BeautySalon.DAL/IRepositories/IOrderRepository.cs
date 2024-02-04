using BeautySalon.DAL.DTO;

namespace BeautySalon.DAL.IRepositories;

public interface IOrderRepository
{
    public List<OrdersDTO> RemoveOrderForClientByOrderId(int orderId);
    public List<UpdateOrderTimeForClientByIdDto> UpdateOrderTimeForClientById(int orderId,int clientId,int masterId,int intervalId);
}