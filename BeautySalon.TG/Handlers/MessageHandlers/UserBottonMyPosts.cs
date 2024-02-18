using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using BeautySalon.BLL.Clents;
using Telegram.Bot.Types.ReplyMarkups;
using BeautySalon.BLL;
using BeautySalon.DAL.DTO;
using BeautySalon.BLL.OrdersForClientById;
using System.Collections;

namespace BeuatySalon.TG.Handlers.MessageHandlers
{
    public class UserBottonMyPosts
    {
        public async void ShowOrders(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            OrderClient orderClient = new OrderClient();
            List<OrdersForClientByIdOutputModel> orders = orderClient.GetOrdersForClientById(7);

           

            List<InlineKeyboardButton[]> buttons = new List<InlineKeyboardButton[]>();
            foreach (var order in orders)
            {

            }

            buttons.Add(new[]
            {
                 InlineKeyboardButton.WithCallbackData(text: $"",
                            callbackData: "вернуться в главное меню")
            });


            buttons.Add(new[]
            {
                InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                            callbackData: "вернуться в главное меню")
            });

            InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(buttons);

            await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id,"Мои записи" ,
                replyMarkup: inlineKeyboard); ;
        }



    }
    
}
