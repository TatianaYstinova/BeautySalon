using BeautySalon.BLL;
using BeautySalon.BLL.Clients;
using BeautySalon.BLL.IClient;
using BeautySalon.BLL.Models;
using BeautySalon.BLL.Models.InputModels;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace BeautySalon.TG.Handlers.MessageHandlers;

public class ShiftsHandler
{
    public async void ChoseShift(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        ShiftsClient shiftsClient = new ShiftsClient(); 
        var shifts = shiftsClient.GetAllShiftsWithFreeIntervalsOnToday();
        if (shifts.Count > 3) //оставляем в списке смен только 3
        {
            shifts.RemoveRange(3,shifts.Count-3);
        }
        if (shifts.Count == 0)
        {
            
        }
        List<InlineKeyboardButton[]> buttons = new List<InlineKeyboardButton[]>();
        int rowsCount = 2;
        for (int i = 0; i <= rowsCount; i += rowsCount)
        {
            var rowShifts = shifts.Skip(i).Take(rowsCount);
            InlineKeyboardButton[] row = rowShifts
                .Select(shift => InlineKeyboardButton.WithCallbackData(text: $"{shift.Title}",
                    callbackData: shift.Id.ToString()))
                .ToArray();
            buttons.Add(row);
        }
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                callbackData: "вернуться в главное меню")
        });
        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(buttons);
        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Выберите удобную смену: ",
            replyMarkup: inlineKeyboard);
    }
    
    public async void ChoseShiftByTitle(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        ShiftsClient shiftsClient = new ShiftsClient(); 
        var shifts = shiftsClient.GetAllShiftsWithFreeIntervalsOnToday();
        if (shifts.Count > 3)
        {
            shifts.RemoveRange(3,shifts.Count-3);
        }
        if (shifts.Count == 0)
        {
            
        }
        List<InlineKeyboardButton[]> buttons = new List<InlineKeyboardButton[]>();
        int rowsCount = 2;
        for (int i = 0; i <= rowsCount; i += rowsCount)
        {
            var rowShifts = shifts.Skip(i).Take(rowsCount);
            InlineKeyboardButton[] row = rowShifts
                .Select(shift => InlineKeyboardButton.WithCallbackData(text: $"{shift.Title}",
                    callbackData: shift.Title.ToString()))
                .ToArray();
            buttons.Add(row);
        }
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                callbackData: "вернуться в главное меню")
        });
        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(buttons);
        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Выберите смену для редактирования:",
            replyMarkup: inlineKeyboard);
    }
    
    public void GetMastersFromShiftForSchedule(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken, string title)
    {
        IShiftsClient shiftsClient = new ShiftsClient();
        var workers = shiftsClient.GetMastersFromShiftByShiftTitle(title);
        List<InlineKeyboardButton[]> buttons = new List<InlineKeyboardButton[]>();
        int rowsCount = 2;
        for (int i = 0; i <= workers.Count; i += rowsCount)
        {
            var rowServices = workers.Skip(i).Take(rowsCount);
            InlineKeyboardButton[] row = rowServices
                .Select(worker => InlineKeyboardButton.WithCallbackData(text: $"{worker.Name} {worker.RoleId}",
                    callbackData: worker.Id.ToString()))
                .ToArray();
            buttons.Add(row);
        }
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Добавить мастера в выбранную смену",
                callbackData: "добавить мастера в выбранную смену")
        });
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                callbackData: "вернуться в главное меню")
        });
        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(buttons);
        botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id,
            "Выберите мастера, которого хотите удалить из выбранной cмены, либо другое действие:",
            replyMarkup: inlineKeyboard);
    }
    
    public async void RemoveMasterFromShiftForSchedule(ITelegramBotClient botClient, Update update,
        CancellationToken cancellationToken)
    {
        InlineKeyboardMarkup inlineKeyboard = new(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData(text: "Удалить мастера из выбранной смены",
                    callbackData: "удалить мастера из выбранной смены"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                    callbackData: "вернуться в главное меню"),
            },
        });
        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Выберите действие:",
            replyMarkup: inlineKeyboard);
    }
    
    public async void RemoveMasterFromShiftByShiftTitle(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken,
        int masterId, string title)
    {
        IShiftsClient shiftsClient = new ShiftsClient();
        MasterIdAndShiftTitleInputModel model = new MasterIdAndShiftTitleInputModel();
        shiftsClient.RemoveMasterFromShiftByShiftTitle(masterId, title);
    }
        
    public void GetMastersAbsentedInSelectedShift(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken, string title)
    {
        IShiftsClient shiftsClient = new ShiftsClient();
        var workers = shiftsClient.GetMastersAbsentedInSelectedShift(title);
        List<InlineKeyboardButton[]> buttons = new List<InlineKeyboardButton[]>();
        int rowsCount = 2;
        for (int i = 0; i <= workers.Count; i += rowsCount)
        {
            var rowServices = workers.Skip(i).Take(rowsCount);
            InlineKeyboardButton[] row = rowServices
                .Select(worker => InlineKeyboardButton.WithCallbackData(text: $"{worker.Name} {worker.RoleId}",
                    callbackData: worker.Id.ToString()))
                .ToArray();
            buttons.Add(row);
        }
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Вернуться к выбору смены",
                callbackData: "вернуться к выбору смены")
        });
        buttons.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                callbackData: "вернуться в главное меню")
        });
        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(buttons);
        botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id,
            "Выберите мастера, которого хотите добавить в выбранную cмену, либо другое действие:",
            replyMarkup: inlineKeyboard);
    }
    
    public async void AddMasterToShift(ITelegramBotClient botClient, Update update,
        CancellationToken cancellationToken)
    {
        InlineKeyboardMarkup inlineKeyboard = new(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData(text: "Добавить мастера в выбранную смену",
                    callbackData: "добавить мастера в выбранную смену"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData(text: "Вернуться в главное меню",
                    callbackData: "вернуться в главное меню"),
            },
        });
        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Выберите действие:",
            replyMarkup: inlineKeyboard);
    }
    
    public async void AddMasterToShiftWithCreatedNewIntervals(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken,int number, int masterId)
    {
        ShiftsClient shiftsClient = new ShiftsClient();
        MasterIdAndShiftNumberInputModel model = new MasterIdAndShiftNumberInputModel
        {
            Number = number,
            MasterId = masterId,
        };
        shiftsClient.AddMasterToShiftWithCreatedNewIntervals(number, masterId);
    }
}