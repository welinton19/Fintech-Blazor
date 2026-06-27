using System.Text.Json.Serialization;

namespace FintechBlazor.Services.Models;

public class AwesomeApiResponse
{
    [JsonPropertyName("USDBRL")]
    public CurrencyInfo USDBRL { get; set; } = new();

    [JsonPropertyName("EURBRL")]
    public CurrencyInfo EURBRL { get; set; } = new();

    [JsonPropertyName("BTCBRL")]
    public CurrencyInfo BTCBRL { get; set; } = new();
}

public class CurrencyInfo 
{
    [JsonPropertyName("bid")]
    public string Bid { get; set; } = string.Empty;

    [JsonPropertyName("ask")]
    public string Ask { get; set; } = string.Empty;

    [JsonPropertyName("varBid")]
    public string VarBid { get; set; } = string.Empty;
}
