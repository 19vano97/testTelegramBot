using System;

namespace TelegramBotWebApp.Models.Message;

public class CallbackQueryModel
{
    public string Id { get; set; }
    public DetailsFromModel From { get; set; }
    public DetailsModel Message { get; set; }
    public ulong Date { get; set; }
    public string Text { get; set; }
    public string Chat_Instance { get; set; }
    public string Data { get; set; }
}
