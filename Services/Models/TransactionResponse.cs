namespace FintechBlazor.Services.Models;

public class TransactionResponse
{
    public long Id { get; set; }
    public long AccountId { get; set; }
    public long ToAccountId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}
