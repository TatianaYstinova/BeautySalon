﻿using BeautySalon.TG.Handlers.MessageHandlers;
using Telegram.Bot.Types;

namespace BeautySalon.TG.States.Schedule;

public class AddMasterToShiftState: AbstractState
{
    public AddMasterToShiftState(string password)
    {
        Password = password;
    }
    
    public override void SendMessage(long chatId, Update update, CancellationToken cancellationToken)
    {
        ShiftsHandler shiftsHandler = new ShiftsHandler();
        shiftsHandler.GetMastersAbsentedInSelectedShift(SingletoneStorage.GetStorage().Client, update, cancellationToken);
    }

    public override AbstractState ReceiveMessage(Update update)
    {
        if (update.CallbackQuery.Data != "вернуться в главное меню")
        {
            return new AddMasterToShiftCompleteState(Password, Number, WorkerId);
        }
        return new AdminControlPanelState(Password);
    }
}