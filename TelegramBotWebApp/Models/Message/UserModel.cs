using System;

namespace TelegramBotWebApp.Models.Message;

public class UserModel
{
    public int Id { get; set; }
    public bool Is_Bot { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Username { get; set; }
}
