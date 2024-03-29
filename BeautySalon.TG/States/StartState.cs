using BeautySalon.TG.MessageHandlers;
using BeautySalon.TG.States.MyRecordsState;
using BeuatySalon.TG.States;
using BeuatySalon.TG.States.MasterState;
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
        if (update.Type == UpdateType.Message && UpdateType.Message != null)
        {
            if (update.Message.Text == "/admin")
            {
                return new AdminState();
            }
            if(update.Message.Text == "/master")
            {
                return new MasterState();
            }
        }
        if (update.Type == UpdateType.CallbackQuery && UpdateType.CallbackQuery != null)
        {
            if (update.CallbackQuery.Data.ToLower() == "записаться")
            {
                return new ServiceState();
            }
            else if (update.CallbackQuery.Data.ToLower() == "как добраться")
            {
                return new HowToGetState();
            }
            else if (update.CallbackQuery.Data.ToLower() == "мои записи")
            {
                return new MyRecords();
            }
            else if (update.CallbackQuery.Data.ToLower() == "оставить отзыв")
            {
                return new LeaveFeedbackState();
            }
        }
        return this;
    }
}