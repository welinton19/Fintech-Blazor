using FintechBlazor.Services.Models;
using System.Net.Http.Json;

namespace FintechBlazor.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _client;

    public AuthService(HttpClient client)
    {
        _client = client;
    }

    public async Task<bool> CadastroAsync(CadastroRequest cadastroRequest)
    {
        var response = await _client.PostAsJsonAsync("api/User/criar", cadastroRequest);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        await Task.CompletedTask;
        return false;
    }

    public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
    {
        var response = await _client.PostAsJsonAsync("api/Login/login", loginRequest);
        if(response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        
        return null;
    }

    public async Task LogoutAsync()
    {
        await Task.CompletedTask;
    }
}
