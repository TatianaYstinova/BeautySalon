using BeautySalon.TG.MessageHandlers;
using BeuatySalon.TG.States;
using BeuatySalon.TG.States.MyRecordsState;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace BeautySalon.TG.States;

public class StartState : AbstractState
{
    public override void SendMessage(long chatId, Update update, CancellationToken cancellationToken)
    {
        UserWelcomeHandler userWelcomeHandler = new UserWelcomeHandler();
        userWelcomeHandler.WelcomeUser(SingletoneStorage.GetStorage().Client, update, cancellationToken);
    }

    public override AbstractState ReceiveMessage(Update update)
    {
        //проверяем, что пришедшее сообщение является нажатием на кнопку и не равно null
        if (update.Type == UpdateType.CallbackQuery && UpdateType.CallbackQuery != null)
        {
            if (update.CallbackQuery.Data.ToLower() == "записаться")
            {
                return new ServiceState();
            }
            else if (update.CallbackQuery.Data.ToLower() == "11") //"как добраться"
            {
            }
            else if (update.CallbackQuery.Data.ToLower() == "21") //"Мои записи"
            {
            }
            else if (update.CallbackQuery.Data.ToLower() == "22") //"Оставить отзыв"
            {
            }
        }

        return this;
    }
}