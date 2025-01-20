using System;

namespace TelegramBotWebApp.Models.Message;

public class ReplyMarkupModel
{
    public List<List<InlineKeyboardModel>> Inline_Keyboard { get; set; }
}