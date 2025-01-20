using System;
using System.Text.Json.Serialization;
using TelegramBotWebApp.Models.Message;

namespace TelegramBotWebApp.Models;

public class DetailsModel
{
    public int Message_Id { get; set; }
    public DetailsFromModel From  { get; set; }
    public ChatModel Chat  { get; set; }
    public ulong Date  { get; set; }
    public string Text  { get; set; }
    public EntityModel[] Entities  { get; set; }
    public ReplyMarkupModel Reply_Markup { get; set; }
}
