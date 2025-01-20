using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

internal class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string token = "7537982814:AAFYxFMnx9Ro6fjJn8YkCcZtNMKYhvN4FIk";
        var botClient = new TelegramBotClient(token);

        var me = await botClient.GetMeAsync();
        Console.WriteLine($"Hello, I am {me.Username}");

        // Start receiving messages
        botClient.StartReceiving(
            updateHandler: HandleUpdateAsync,
            errorHandler: HandleErrorAsync
            
        );

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Message != null && update.Message.Text != null)
        {
            Console.WriteLine($"Received a message from {update.Message.Chat.Username}: {update.Message.Text}");
            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Hello! This is a bot response.");
        }
    }

    static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Error: {exception.Message}");
        return Task.CompletedTask;
    }
}
