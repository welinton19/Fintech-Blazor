using Fintech.Domain.Entities;
using System.Transactions;
using Transaction = Fintech.Domain.Entities.Transaction;

namespace FintechBlazor.Services.Models;

public class AccountRequest
{
    
    public long UserId { get; set; }

    public string Currency { get; set; }
    public decimal Balance { get; set; }
    public bool IsActived { get; set; }
    public DateOnly CrateCount { get; set; }
    public User user { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
