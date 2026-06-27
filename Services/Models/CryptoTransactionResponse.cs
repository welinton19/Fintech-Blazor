using Fintech.Domain.Enum;

namespace FintechBlazor.Services.Models;

public class CryptoTransactionResponse
{
    public long Id { get; set; }
    public long WalletId { get; set; }
    public long? LinkedTransactionId { get; set; }
    public decimal CryptoAmount { get; set; }
    public decimal FiatAmount { get; set; }
    public decimal QuotePrice { get; set; }
    public string? FiatCurrency { get; set; }
    public _cryptoTransactionRepository Type { get; set; }
    public DateOnly ExecutedAt { get; set; }
}
