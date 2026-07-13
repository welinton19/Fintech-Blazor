using FintechBlazor.Services.Models;

namespace FintechBlazor.Services;

public interface IPixKeyService
{
    Task<RegisterPixKeyResponse?> CadastrarChaveAsync(RegisterPixKeyRequest request);
    Task<List<RegisterPixKeyResponse>> GetChavesByUserIdAsync(long userId);
    Task<bool> DeletarChaveAsync(long id);
}
