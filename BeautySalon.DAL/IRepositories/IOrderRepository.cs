using BeautySalon.DAL.DTO;

namespace BeautySalon.DAL.IRepositories;

public interface IOrderRepository
{
    public List<OrdersDTO> GetAllOrdersForClient();

    public void RemoveOrderForClientByOrderId (int  orderId);
}