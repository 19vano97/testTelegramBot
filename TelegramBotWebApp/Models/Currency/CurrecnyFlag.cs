using System;

namespace TelegramBotWebApp.Models.Currency;

public class CurrecnyFlag
{
    public Dictionary<Currencies, string> CurrencyFlagDictionary = new Dictionary<Currencies, string>();

    public CurrecnyFlag()
    {
        CurrencyFlagDictionary.Add(Currencies.USD, "🇺🇸");
        CurrencyFlagDictionary.Add(Currencies.AED, "🇦🇪"); // United Arab Emirates
        CurrencyFlagDictionary.Add(Currencies.AFN, "🇦🇫"); // Afghanistan
        CurrencyFlagDictionary.Add(Currencies.ALL, "🇦🇱"); // Albania
        CurrencyFlagDictionary.Add(Currencies.AMD, "🇦🇲"); // Armenia
        CurrencyFlagDictionary.Add(Currencies.ANG, "🇳🇱"); // Netherlands Antilles (uses NL flag)
        CurrencyFlagDictionary.Add(Currencies.AOA, "🇦🇴"); // Angola
        CurrencyFlagDictionary.Add(Currencies.ARS, "🇦🇷"); // Argentina
        CurrencyFlagDictionary.Add(Currencies.AUD, "🇦🇺"); // Australia
        CurrencyFlagDictionary.Add(Currencies.AWG, "🇦🇼"); // Aruba
        CurrencyFlagDictionary.Add(Currencies.AZN, "🇦🇿"); // Azerbaijan
        CurrencyFlagDictionary.Add(Currencies.BAM, "🇧🇦"); // Bosnia and Herzegovina
        CurrencyFlagDictionary.Add(Currencies.BBD, "🇧🇧"); // Barbados
        CurrencyFlagDictionary.Add(Currencies.BDT, "🇧🇩"); // Bangladesh
        CurrencyFlagDictionary.Add(Currencies.BGN, "🇧🇬"); // Bulgaria
        CurrencyFlagDictionary.Add(Currencies.BHD, "🇧🇭"); // Bahrain
        CurrencyFlagDictionary.Add(Currencies.BIF, "🇧🇮"); // Burundi
        CurrencyFlagDictionary.Add(Currencies.BMD, "🇧🇲"); // Bermuda
        CurrencyFlagDictionary.Add(Currencies.BND, "🇧🇳"); // Brunei
        CurrencyFlagDictionary.Add(Currencies.BOB, "🇧🇴"); // Bolivia
        CurrencyFlagDictionary.Add(Currencies.BRL, "🇧🇷"); // Brazil
        CurrencyFlagDictionary.Add(Currencies.BSD, "🇧🇸"); // Bahamas
        CurrencyFlagDictionary.Add(Currencies.BTN, "🇧🇹"); // Bhutan
        CurrencyFlagDictionary.Add(Currencies.BWP, "🇧🇼"); // Botswana
        CurrencyFlagDictionary.Add(Currencies.BYN, "🇧🇾"); // Belarus
        CurrencyFlagDictionary.Add(Currencies.BZD, "🇧🇿"); // Belize
        CurrencyFlagDictionary.Add(Currencies.CAD, "🇨🇦"); // Canada
        CurrencyFlagDictionary.Add(Currencies.CDF, "🇨🇩"); // Congo (DR)
        CurrencyFlagDictionary.Add(Currencies.CHF, "🇨🇭"); // Switzerland
        CurrencyFlagDictionary.Add(Currencies.CLP, "🇨🇱"); // Chile
        CurrencyFlagDictionary.Add(Currencies.CNY, "🇨🇳"); // China
        CurrencyFlagDictionary.Add(Currencies.COP, "🇨🇴"); // Colombia
        CurrencyFlagDictionary.Add(Currencies.CRC, "🇨🇷"); // Costa Rica
        CurrencyFlagDictionary.Add(Currencies.CUP, "🇨🇺"); // Cuba
        CurrencyFlagDictionary.Add(Currencies.CVE, "🇨🇻"); // Cape Verde
        CurrencyFlagDictionary.Add(Currencies.CZK, "🇨🇿"); // Czech Republic
        CurrencyFlagDictionary.Add(Currencies.DJF, "🇩🇯"); // Djibouti
        CurrencyFlagDictionary.Add(Currencies.DKK, "🇩🇰"); // Denmark
        CurrencyFlagDictionary.Add(Currencies.DOP, "🇩🇴"); // Dominican Republic
        CurrencyFlagDictionary.Add(Currencies.DZD, "🇩🇿"); // Algeria
        CurrencyFlagDictionary.Add(Currencies.EGP, "🇪🇬"); // Egypt
        CurrencyFlagDictionary.Add(Currencies.ERN, "🇪🇷"); // Eritrea
        CurrencyFlagDictionary.Add(Currencies.ETB, "🇪🇹"); // Ethiopia
        CurrencyFlagDictionary.Add(Currencies.EUR, "🇪🇺"); // European Union
        CurrencyFlagDictionary.Add(Currencies.FJD, "🇫🇯"); // Fiji
        CurrencyFlagDictionary.Add(Currencies.FKP, "🇫🇰"); // Falkland Islands
        CurrencyFlagDictionary.Add(Currencies.FOK, "🇫🇴"); // Faroe Islands
        CurrencyFlagDictionary.Add(Currencies.GBP, "🇬🇧"); // United Kingdom
        CurrencyFlagDictionary.Add(Currencies.GEL, "🇬🇪"); // Georgia
        CurrencyFlagDictionary.Add(Currencies.GGP, "🇬🇬"); // Guernsey
        CurrencyFlagDictionary.Add(Currencies.GHS, "🇬🇭"); // Ghana
        CurrencyFlagDictionary.Add(Currencies.GIP, "🇬🇮"); // Gibraltar
        CurrencyFlagDictionary.Add(Currencies.GMD, "🇬🇲"); // Gambia
        CurrencyFlagDictionary.Add(Currencies.GNF, "🇬🇳"); // Guinea
        CurrencyFlagDictionary.Add(Currencies.GTQ, "🇬🇹"); // Guatemala
        CurrencyFlagDictionary.Add(Currencies.GYD, "🇬🇾"); // Guyana
        CurrencyFlagDictionary.Add(Currencies.HKD, "🇭🇰"); // Hong Kong
        CurrencyFlagDictionary.Add(Currencies.HNL, "🇭🇳"); // Honduras
        CurrencyFlagDictionary.Add(Currencies.HRK, "🇭🇷"); // Croatia
        CurrencyFlagDictionary.Add(Currencies.HTG, "🇭🇹"); // Haiti
        CurrencyFlagDictionary.Add(Currencies.HUF, "🇭🇺"); // Hungary
        CurrencyFlagDictionary.Add(Currencies.IDR, "🇮🇩"); // Indonesia
        CurrencyFlagDictionary.Add(Currencies.ILS, "🇮🇱"); // Israel
        CurrencyFlagDictionary.Add(Currencies.IMP, "🇮🇲"); // Isle of Man
        CurrencyFlagDictionary.Add(Currencies.INR, "🇮🇳"); // India
        CurrencyFlagDictionary.Add(Currencies.IQD, "🇮🇶"); // Iraq
        CurrencyFlagDictionary.Add(Currencies.IRR, "🇮🇷"); // Iran
        CurrencyFlagDictionary.Add(Currencies.ISK, "🇮🇸"); // Iceland
        CurrencyFlagDictionary.Add(Currencies.JEP, "🇯🇪"); // Jersey
        CurrencyFlagDictionary.Add(Currencies.JMD, "🇯🇲"); // Jamaica
        CurrencyFlagDictionary.Add(Currencies.JOD, "🇯🇴"); // Jordan
        CurrencyFlagDictionary.Add(Currencies.JPY, "🇯🇵"); // Japan
        CurrencyFlagDictionary.Add(Currencies.KES, "🇰🇪"); // Kenya
        CurrencyFlagDictionary.Add(Currencies.KGS, "🇰🇬"); // Kyrgyzstan
        CurrencyFlagDictionary.Add(Currencies.KHR, "🇰🇭"); // Cambodia
        CurrencyFlagDictionary.Add(Currencies.KID, "🇰🇮"); // Kiribati
        CurrencyFlagDictionary.Add(Currencies.KMF, "🇰🇲"); // Comoros
        CurrencyFlagDictionary.Add(Currencies.KRW, "🇰🇷"); // South Korea
        CurrencyFlagDictionary.Add(Currencies.KWD, "🇰🇼"); // Kuwait
        CurrencyFlagDictionary.Add(Currencies.KYD, "🇰🇾"); // Cayman Islands
        CurrencyFlagDictionary.Add(Currencies.KZT, "🇰🇿"); // Kazakhstan
        CurrencyFlagDictionary.Add(Currencies.LAK, "🇱🇦"); // Laos
        CurrencyFlagDictionary.Add(Currencies.LBP, "🇱🇧"); // Lebanon
        CurrencyFlagDictionary.Add(Currencies.LKR, "🇱🇰"); // Sri Lanka
        CurrencyFlagDictionary.Add(Currencies.LRD, "🇱🇷"); // Liberia
        CurrencyFlagDictionary.Add(Currencies.LSL, "🇱🇸"); // Lesotho
        CurrencyFlagDictionary.Add(Currencies.LYD, "🇱🇾"); // Libya
        CurrencyFlagDictionary.Add(Currencies.MAD, "🇲🇦"); // Morocco
        CurrencyFlagDictionary.Add(Currencies.MDL, "🇲🇩"); // Moldova
        CurrencyFlagDictionary.Add(Currencies.MGA, "🇲🇬"); // Madagascar
        CurrencyFlagDictionary.Add(Currencies.MKD, "🇲🇰"); // North Macedonia
        CurrencyFlagDictionary.Add(Currencies.MMK, "🇲🇲"); // Myanmar
        CurrencyFlagDictionary.Add(Currencies.MNT, "🇲🇳"); // Mongolia
        CurrencyFlagDictionary.Add(Currencies.MOP, "🇲🇴"); // Macao
        CurrencyFlagDictionary.Add(Currencies.MRU, "🇲🇷"); // Mauritania
        CurrencyFlagDictionary.Add(Currencies.MUR, "🇲🇺"); // Mauritius
        CurrencyFlagDictionary.Add(Currencies.MVR, "🇲🇻"); // Maldives
        CurrencyFlagDictionary.Add(Currencies.MWK, "🇲🇼"); // Malawi
        CurrencyFlagDictionary.Add(Currencies.MXN, "🇲🇽"); // Mexico
        CurrencyFlagDictionary.Add(Currencies.MYR, "🇲🇾"); // Malaysia
        CurrencyFlagDictionary.Add(Currencies.MZN, "🇲🇿"); // Mozambique
        CurrencyFlagDictionary.Add(Currencies.NAD, "🇳🇦"); // Namibia
        CurrencyFlagDictionary.Add(Currencies.NGN, "🇳🇬"); // Nigeria
        CurrencyFlagDictionary.Add(Currencies.NIO, "🇳🇮"); // Nicaragua
        CurrencyFlagDictionary.Add(Currencies.NOK, "🇳🇴"); // Norway
        CurrencyFlagDictionary.Add(Currencies.NPR, "🇳🇵"); // Nepal
        CurrencyFlagDictionary.Add(Currencies.NZD, "🇳🇿"); // New Zealand
        CurrencyFlagDictionary.Add(Currencies.OMR, "🇴🇲"); // Oman
        CurrencyFlagDictionary.Add(Currencies.PAB, "🇵🇦"); // Panama
        CurrencyFlagDictionary.Add(Currencies.PEN, "🇵🇪"); // Peru
        CurrencyFlagDictionary.Add(Currencies.PGK, "🇵🇬"); // Papua New Guinea
        CurrencyFlagDictionary.Add(Currencies.PHP, "🇵🇭"); // Philippines
        CurrencyFlagDictionary.Add(Currencies.PKR, "🇵🇰"); // Pakistan
        CurrencyFlagDictionary.Add(Currencies.PLN, "🇵🇱"); // Poland
        CurrencyFlagDictionary.Add(Currencies.PYG, "🇵🇾"); // Paraguay
        CurrencyFlagDictionary.Add(Currencies.QAR, "🇶🇦"); // Qatar
        CurrencyFlagDictionary.Add(Currencies.RON, "🇷🇴"); // Romania
        CurrencyFlagDictionary.Add(Currencies.RSD, "🇷🇸"); // Serbia
        CurrencyFlagDictionary.Add(Currencies.RUB, "🇷🇺"); // Russia
        CurrencyFlagDictionary.Add(Currencies.RWF, "🇷🇼"); // Rwanda
        CurrencyFlagDictionary.Add(Currencies.SAR, "🇸🇦"); // Saudi Arabia
        CurrencyFlagDictionary.Add(Currencies.SBD, "🇸🇧"); // Solomon Islands
        CurrencyFlagDictionary.Add(Currencies.SCR, "🇸🇨"); // Seychelles
        CurrencyFlagDictionary.Add(Currencies.SDG, "🇸🇩"); // Sudan
        CurrencyFlagDictionary.Add(Currencies.SEK, "🇸🇪"); // Sweden
        CurrencyFlagDictionary.Add(Currencies.SGD, "🇸🇬"); // Singapore
        CurrencyFlagDictionary.Add(Currencies.SHP, "🇸🇭"); // Saint Helena
        CurrencyFlagDictionary.Add(Currencies.SLE, "🇸🇱"); // Sierra Leone
        CurrencyFlagDictionary.Add(Currencies.SLL, "🇸🇱"); // Sierra Leone
        CurrencyFlagDictionary.Add(Currencies.SOS, "🇸🇴"); // Somalia
        CurrencyFlagDictionary.Add(Currencies.SRD, "🇸🇷"); // Suriname
        CurrencyFlagDictionary.Add(Currencies.SSP, "🇸🇸"); // South Sudan
        CurrencyFlagDictionary.Add(Currencies.STN, "🇸🇹"); // Sao Tome and Principe
        CurrencyFlagDictionary.Add(Currencies.SYP, "🇸🇾"); // Syria
        CurrencyFlagDictionary.Add(Currencies.SZL, "🇸🇿"); // Eswatini
        CurrencyFlagDictionary.Add(Currencies.THB, "🇹🇭"); // Thailand
        CurrencyFlagDictionary.Add(Currencies.TJS, "🇹🇯"); // Tajikistan
        CurrencyFlagDictionary.Add(Currencies.TMT, "🇹🇲"); // Turkmenistan
        CurrencyFlagDictionary.Add(Currencies.TND, "🇹🇳"); // Tunisia
        CurrencyFlagDictionary.Add(Currencies.TOP, "🇹🇴"); // Tonga
        CurrencyFlagDictionary.Add(Currencies.TRY, "🇹🇷"); // Turkey
        CurrencyFlagDictionary.Add(Currencies.TTD, "🇹🇹"); // Trinidad and Tobago
        CurrencyFlagDictionary.Add(Currencies.TVD, "🇹🇻"); // Tuvalu
        CurrencyFlagDictionary.Add(Currencies.TWD, "🇹🇼"); // Taiwan
        CurrencyFlagDictionary.Add(Currencies.TZS, "🇹🇿"); // Tanzania
        CurrencyFlagDictionary.Add(Currencies.UAH, "🇺🇦"); // Ukraine
        CurrencyFlagDictionary.Add(Currencies.UGX, "🇺🇬"); // Uganda
        CurrencyFlagDictionary.Add(Currencies.UYU, "🇺🇾"); // Uruguay
        CurrencyFlagDictionary.Add(Currencies.UZS, "🇺🇿"); // Uzbekistan
        CurrencyFlagDictionary.Add(Currencies.VES, "🇻🇪"); // Venezuela
        CurrencyFlagDictionary.Add(Currencies.VND, "🇻🇳"); // Vietnam
        CurrencyFlagDictionary.Add(Currencies.VUV, "🇻🇺"); // Vanuatu
        CurrencyFlagDictionary.Add(Currencies.WST, "🇼🇸"); // Samoa
        CurrencyFlagDictionary.Add(Currencies.XAF, "🇨🇲"); // Central African CFA Franc (Cameroon as example)
        CurrencyFlagDictionary.Add(Currencies.XCD, "🇦🇬"); // East Caribbean Dollar (Antigua as example)
        CurrencyFlagDictionary.Add(Currencies.XDR, "🌐"); // Special Drawing Rights (No flag, use globe)
        CurrencyFlagDictionary.Add(Currencies.XOF, "🇸🇳"); // West African CFA Franc (Senegal as example)
        CurrencyFlagDictionary.Add(Currencies.XPF, "🇵🇫"); // CFP Franc (French Polynesia as example)
        CurrencyFlagDictionary.Add(Currencies.YER, "🇾🇪"); // Yemen
        CurrencyFlagDictionary.Add(Currencies.ZAR, "🇿🇦"); // South Africa
        CurrencyFlagDictionary.Add(Currencies.ZMW, "🇿🇲"); // Zambia
        CurrencyFlagDictionary.Add(Currencies.ZWL, "🇿🇼"); // Zimbabwe
    }
}
