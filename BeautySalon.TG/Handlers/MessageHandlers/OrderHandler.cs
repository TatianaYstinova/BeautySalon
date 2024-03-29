﻿using BeautySalon.BLL.Clients;
using BeautySalon.BLL.Models.InputModels;
using BeautySalon.BLL.Models.Output_Models;
using BeautySalon.BLL.OrdersForClientById;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;

namespace BeautySalon.TG.Handlers.MessageHandlers
{
    public class OrderHandler
    {
        public void CreateNewOrder(NewOrderInputModel model)
        {
            OrderClient orderClient = new OrderClient();
            orderClient.CreateNewOrder(model);
        }

        public List<OrdersForClientByIdOutputModel> GetOrdersByClientId(int clientId)
        {
            OrderClient orderClient = new OrderClient();
            List<OrdersForClientByIdOutputModel> result = orderClient.GetOrdersForClientById(clientId);

            return result;
        }
        public void RemoveOrderForClientByOrderId(RemoveOrderForClientIdInput removeOrderForClient)
        {
            OrderClient orderClient = new OrderClient();
            orderClient.RemoveOrderForClientByOrderId(removeOrderForClient);
        }
        public void UpdateOrderTimeForClientById(UpdateOrderClientByIdInputModel orders)
        {
            OrderClient orderClient = new OrderClient();
            orderClient.UpdateOrderTimeForClientById(orders);
        }
        public List<GetAllOrdersOnTodayForMasterOutputModel> GetAllOrdersOnTodayForMasters()
        {
            OrderClient orderClient = new OrderClient();
            List<GetAllOrdersOnTodayForMasterOutputModel> result = orderClient.GetAllOrdersOnTodayForMasters();

            return result;
        }
        public List<GetOrdersByMasterIdOutputModel> GetOrdersByMasterId(int id)
        {
            OrderClient orderClient = new OrderClient();
            List<GetOrdersByMasterIdOutputModel> result = orderClient.GetOrdersByMasterId((int)id);
            return result;
        }
    }
}

