using System;
using Telegram.Bot;

namespace TelegramBotConsoleApp;

public class Messenger
{
    private string _token;
    private TelegramBotClient _botClient;

    public Messenger(string token)
    {
        _token = token;
        _botClient = new TelegramBotClient(_token);
        var me = _botClient.GetMeAsync().Result;
        Console.WriteLine($"Bot id: {me.Id}, Bot Name: {me.FirstName}");
    }

    public TelegramBotClient BotClient
    {
        get => _botClient;
    }
}
