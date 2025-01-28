using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotWebApp.Models;
using TelegramBotWebApp.Models.Const;
using TelegramBotWebApp.Models.Currency;
using TelegramBotWebApp.Resources;
using TelegramBotWebApp.Services.Implementation.Currency;
using TelegramBotWebApp.Views.Menus.CurrencyMenu;

namespace TelegramBotWebApp.Controllers
{
    [ApiController]
    [Route("bot")]
    public class BotController : Controller
    {
        private static TelegramBotClient _botClient;
        private static IConfiguration _configuration;
        private static string _currencyApiUrl;

        public BotController(IConfiguration configuration)
        {
            _configuration = configuration;
            _currencyApiUrl = _configuration.GetConnectionString("CurrencyApi");
            _botClient = new TelegramBotClient(_configuration.GetConnectionString("TelegramApiKey"));
        }

        [HttpPost("webhook")]
        public async Task<ActionResult> Webhook([FromBody] JsonElement updateJson)
        {
            var update = JsonSerializer.Deserialize<MessageModel>(updateJson.ToString(), 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (update == null)
            {
                return BadRequest("Invalid update payload");
            }

            if (update?.Callback_Query?.Data == Command.CURRENCY)
            {
                await GetCurrency(update);
            }
            else if (Enum.TryParse(typeof(Currencies), update?.Callback_Query?.Data, out var result))
            {
                await GetCurrencyByValue(update);
            }
            else if (update.Message?.Text == Command.START)
            {
                GetStarted(update);
            }
            // else
            // {
            //     await _botClient.SendTextMessageAsync(update.Message.Chat.Id, "Please type 'currency' to get the latest rates.");
            // }

            return Ok();
        }

        private static async Task GetStarted(MessageModel message)
        {
            var chatId = message.Message.Chat.Id;
            var currencyInfo = MainResource.HelloWorld;

            InlineKeyboardButton button1 = new InlineKeyboardButton("Hello");
            InlineKeyboardButton button2 = new InlineKeyboardButton("Currency");
            button1.CallbackData = "/hello";
            button2.CallbackData = "/currency";

            InlineKeyboardMarkup buttonsWithMarkup = new InlineKeyboardMarkup().AddButtons(button1, button2);
            await _botClient.SendTextMessageAsync(chatId, currencyInfo, replyMarkup: buttonsWithMarkup);

        }

        private static async Task GetCurrency(MessageModel message)
        {
            var chatId = message.Message == null ? message.Callback_Query.Message.Chat.Id : message.Message.Chat.Id;
            var currencyInfo = "Choose currency";

            await _botClient.SendTextMessageAsync(chatId, currencyInfo, replyMarkup: new CurrencyMenu().ChooseCurrencyMarkup(5));
        }

        private static async Task GetCurrencyByValue(MessageModel message)
        {
            var chatId = message.Message == null ? message.Callback_Query.Message.Chat.Id : message.Message.Chat.Id;
            var currencyInfo = await GetCurrencyRatesAsync(message?.Callback_Query?.Data);

            await _botClient.SendTextMessageAsync(chatId, currencyInfo);
        }

        private static async Task<string> GetCurrencyRatesAsync(string currency)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(_currencyApiUrl + currency);
                
                return new CurrencyMenu().OutputCurrencyConvert(response, currency);
            }
        }
    }
}
