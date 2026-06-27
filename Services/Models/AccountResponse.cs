namespace FintechBlazor.Services.Models;

public class AccountResponse
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public string Currency { get; set; }
    public decimal Balance { get; set; }
    public bool IsActived { get; set; }
    public DateOnly CrateCount { get; set; }
}
