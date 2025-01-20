using System;
using System.Text.Json.Serialization;

namespace TelegramBotWebApp.Models;

public class CurrencyExchangeModel
{
    [JsonPropertyName("result")]
    public string Result { get; set; }

    [JsonPropertyName("documentation")]
    public string Documentation { get; set; }

    [JsonPropertyName("terms_of_use")]
    public string TermsOfUse { get; set; }

    [JsonPropertyName("time_last_update_unix")]
    public long TimeLastUpdateUnix { get; set; }

    [JsonPropertyName("time_last_update_utc")]
    public string TimeLastUpdateUtc { get; set; }

    [JsonPropertyName("time_next_update_unix")]
    public long TimeNextUpdateUnix { get; set; }

    [JsonPropertyName("time_next_update_utc")]
    public string TimeNextUpdateUtc { get; set; }

    [JsonPropertyName("base_code")]
    public string BaseCode { get; set; }

    [JsonPropertyName("conversion_rates")]
    public ConversionRatesModel ConversionRates { get; set; }
}
