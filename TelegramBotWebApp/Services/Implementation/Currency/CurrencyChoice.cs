using System;
using TelegramBotWebApp.Models.Currency;

namespace TelegramBotWebApp.Services.Implementation.Currency;

public class CurrencyChoice
{
    public List<(Currencies, string)> GetRandomCurrency(int random)
    {
        var res = new List<(Currencies, string)>();
        int[] rnd = new int[random];
        var curFlag = new CurrecnyFlag();

        rnd[0] = new Random().Next(0, Enum.GetNames(typeof(Currencies)).Count());
        bool isEqual = true;

        do
        {
            for (var i = 0; i < rnd.Length; i++)
            {
                rnd[i] = new Random().Next(0, Enum.GetNames(typeof(Currencies)).Count());
            }

            if (!rnd.GroupBy(x => x).Any(g => g.Count() > 1))
            {
                isEqual = false;
            }
        } while (isEqual);

        for (var i = 0; i < rnd.Length; i++)
        {
            res.Add(new ((Currencies)rnd[i], curFlag.CurrencyFlagDictionary.Where(f => f.Key == (Currencies)rnd[i]).Select(f => f.Value).FirstOrDefault()));
        }

        return res;
    }
}
