using System;
using System.Text.Json.Serialization;
using TelegramBotWebApp.Models.Message;

namespace TelegramBotWebApp.Models;

public class MessageModel
{
    public int Update_Id { get;set; }
    public DetailsModel Message { get;set; }
    public CallbackQueryModel Callback_Query { get;set; }
}
