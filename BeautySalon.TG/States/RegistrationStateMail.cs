﻿using BeautySalon.BLL;
using BeautySalon.BLL.IClient;
using BeautySalon.BLL.Models;
using BeautySalon.BLL.Models.InputModels;
using BeautySalon.TG.Handlers.MessageHandlers;
using BeautySalon.TG.States;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BeautySalon.TG.States;

public class RegistrationStateMail : AbstractState
{
    public RegistrationStateMail(int serviceID, int shiftId, int intervalId, int typeId, string name, string phone)
    {
        ServiceId = serviceID;
        IntervalId = intervalId;
        TypeId = typeId;
        Name = name;
        Phone = phone;
    }

    public async override void SendMessage(long chatId, Update update, CancellationToken cancellationToken)
    {
        await SingletoneStorage.GetStorage().Client
            .SendTextMessageAsync(chatId,
            "Желаете ли оставить Ваш e-mail для подписки на нашу рассылку с акциями и персональными предложениями?\n(в строке отправки сообщения введите ваш актуальный адрес либо \"нет\", если желаете отказаться от нашей рассылки)");
    }

    public override AbstractState ReceiveMessage(Update update)
    {
        Mail = update?.Message.Text;
        UserName = update?.Message.Chat.Username;
        SingletoneStorage.GetStorage().Client
            .SendTextMessageAsync(update.Message.Chat.Id,
            "Поздравляем! Вы успешно зарегистрировались в виртуальной системе салона \"Beautiful Girl\".");
        long id = update.Message.Chat.Id;
        UserHandler userHandler = new UserHandler();
        AddUserByChatIdInputModel model = new AddUserByChatIdInputModel
        {
            ChatId = Convert.ToInt32(id),
            UserName = UserName,
            Name = Name,
            Phone = Phone,
            Mail = Mail,
            Salary = 0,
            RoleId = 3,
            IsDeleted = 0,
            IsBlocked = 0,
        };
        userHandler.AddUserToDB(model);
        int clientIdFromBase = userHandler.GetClientByNameAndPhone(Name, Phone);
        IntervalIdInputModel modelIntervalIdInputModel = new IntervalIdInputModel
        {
            Id = IntervalId
        };
        int masterIdFromBase = userHandler.GetFreeMasterIdByIntervalId(IntervalId);
        OrderHandler orderHandler = new OrderHandler();
        NewOrderInputModel orderInputModel = new NewOrderInputModel
        {
            ClientId = clientIdFromBase,
            MasterId = masterIdFromBase,
            ServiceId = ServiceId,
            IntervalId = IntervalId,
            Date = DateTime.Now
        };
        orderHandler.CreateNewOrder(orderInputModel);
        return new RegistrationOverState();
    }
}