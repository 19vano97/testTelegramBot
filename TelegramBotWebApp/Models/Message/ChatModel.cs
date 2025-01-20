using System;

namespace TelegramBotWebApp.Models.Message;

public class ChatModel
{
    // public MessageUserModel User { get; set; }
    public int Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Username { get; set; }
    public string Type { get; set; }
}
