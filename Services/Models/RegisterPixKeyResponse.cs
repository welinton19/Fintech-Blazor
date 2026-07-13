using Fintech.Domain.Enum;

namespace FintechBlazor.Services.Models;

public class RegisterPixKeyResponse
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public string KeyType { get; set; } = string.Empty;
    public string KeyValue { get; set; } = string.Empty;
}
