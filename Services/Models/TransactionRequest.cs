namespace FintechBlazor.Services.Models;

public class TransactionRequest
{
    public long fromAcountId { get; set; }
    public long ToAccountId { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
}
