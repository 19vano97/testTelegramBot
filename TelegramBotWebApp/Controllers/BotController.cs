using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotWebApp.Interfaces;
using TelegramBotWebApp.Models;

namespace TelegramBotWebApp.Controllers
{
    [ApiController]
    [Route("bot")]
    public class BotController : Controller
    {
        private static readonly IValidationDataModel _token = new ValidationDataModel();
        private static readonly TelegramBotClient _botClient = new TelegramBotClient(_token.token);

        private static readonly string CurrencyApiUrl = "https://v6.exchangerate-api.com/v6/26e3acf6b9e08c4da15f2574/latest/UAH";

        [HttpPost("webhook")]
        public async Task<ActionResult> Webhook([FromBody] JsonElement updateJson)
        {
            var update = JsonSerializer.Deserialize<MessageModel>(updateJson.ToString(), 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (update == null)
            {
                return BadRequest("Invalid update payload");
            }

            if (update?.Callback_Query?.Data == "/currency")
            {
                GetCurrency(update);
            }
            else if (update.Message?.Text == "/start")
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
            var currencyInfo = "Hello world";

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
            var currencyInfo = await GetCurrencyRatesAsync();

            await _botClient.SendTextMessageAsync(chatId, currencyInfo);
        }

        private static async Task<string> GetCurrencyRatesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(CurrencyApiUrl);
                var json = JsonSerializer.Deserialize<CurrencyExchangeModel>(response);

                var usdToEur = json.ConversionRates.EUR;
                var usdToUah = json.ConversionRates.USD;
                var usdToGbp = json.ConversionRates.GBP;
                
                return $"💵 Current Rates:\n1 UAH = {usdToEur} EUR\n1 USD = {usdToUah} UAH\n1 USD = {usdToGbp} GBP";
            }
        }
    }
}
