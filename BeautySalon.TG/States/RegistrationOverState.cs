﻿using BeautySalon.TG;
using BeautySalon.TG.States;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace BeautySalon.TG.States;

public class RegistrationOverState: AbstractState
{
    public override void SendMessage(long chatId, Update update, CancellationToken cancellationToken)
    {
        List<InlineKeyboardButton[]> buttons = new List<InlineKeyboardButton[]>();
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                callbackData: "вернуться в главное меню")
        });
        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(buttons);
        if (update.Message != null)
        {
            SingletoneStorage.GetStorage().Client.SendTextMessageAsync(update.Message.Chat.Id,
                "Будем рады видеть Вас в нашем салоне!\nНаш администратор свяжется с Вами накануне посещения для подтверждения Вашего визита.\nВсего Вам наилучшего!",
                replyMarkup: inlineKeyboard);    
        }
        else
        {
            SingletoneStorage.GetStorage().Client.SendTextMessageAsync(update.CallbackQuery.From.Id,
                "Будем рады видеть Вас в нашем салоне!\nНаш администратор свяжется с Вами накануне посещения для подтверждения Вашего визита.\nВсего Вам наилучшего!",
                replyMarkup: inlineKeyboard);    
        }
    }

    public override AbstractState ReceiveMessage(Update update)
    {
        if (update.CallbackQuery.Data == "вернуться в главное меню")
        {
            return new StartState();
        }
        return this;
    }
}