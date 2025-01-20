using System;

namespace TelegramBotWebApp.Models.Message;

public class EntityModel
{
    public int Offset { get; set; }
    public int Length { get; set; }
    public string Type { get; set; }
}
