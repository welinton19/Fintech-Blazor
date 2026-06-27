using Fintech.Domain.Enum;

namespace FintechBlazor.Services.Models;

public class CryptoTransactionRequest
{
    public long WalletId { get; set; }
    public string CryptoCurrency { get; set; } = null!;
    public decimal Amount { get; set; }
    public decimal Price { get; set; }
    public long? LinkedTransactionId { get; set; }
    public _cryptoTransactionRepository Type { get; set; }
}
