using System;
using System.Text.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotWebApp.Models;
using TelegramBotWebApp.Resources;
using TelegramBotWebApp.Services.Implementation.Currency;

namespace TelegramBotWebApp.Views.Menus.CurrencyMenu;

public class CurrencyMenu
{
    public InlineKeyboardMarkup ChooseCurrencyMarkup(int amount)
    {
        InlineKeyboardButton[] buttons = new InlineKeyboardButton[amount];
        var randomCurrencies = new CurrencyChoice().GetRandomCurrency(amount);

        int index = 0;

        foreach (var item in randomCurrencies)
        {
            buttons[index] = new InlineKeyboardButton(item.Item2);
            buttons[index].CallbackData = item.Item1.ToString();
            index++;
        }
        
        return new InlineKeyboardMarkup().AddButtons(buttons);
    }

    public string OutputCurrencyConvert(string response, string currency)
    {
        var json = JsonSerializer.Deserialize<CurrencyExchangeModel>(response);

        var currencyToEur = json.ConversionRates.EUR;
        var currencyToUSD = json.ConversionRates.USD;
        var currencyToGbp = json.ConversionRates.GBP;
        
        return $"💵 Current Rates:\n1 {currency} = {currencyToEur} EUR\n1 {currency} = {currencyToUSD} USD\n1 {currency} = {currencyToGbp} GBP";
    }
}
