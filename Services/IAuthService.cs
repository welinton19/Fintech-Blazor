using FintechBlazor.Services.Models;

namespace FintechBlazor.Services;

public interface IAuthService
{
    Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    Task<bool> CadastroAsync(CadastroRequest cadastroRequest);
    Task LogoutAsync();
    Task<bool> IsAuthenticatedAsync();
}
