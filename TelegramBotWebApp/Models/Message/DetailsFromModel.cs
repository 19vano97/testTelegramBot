using System;
using Telegram.Bot.Types;

namespace TelegramBotWebApp.Models.Message;

public class DetailsFromModel
{
    // public MessageUserModel User { get; set; }
    public ulong Id { get; set; }
    public bool Is_Bot { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Username { get; set; }
    public string Language_Code { get; set; }
}