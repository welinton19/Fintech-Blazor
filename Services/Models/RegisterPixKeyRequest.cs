using Fintech.Domain.Enum;

namespace FintechBlazor.Services.Models;


public class RegisterPixKeyRequest
{
    public PixKeyType KeyType { get; set; }
    public string KeyValue { get; set; }
    public long UserId { get; set; }
}
