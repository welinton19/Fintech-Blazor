using FintechBlazor.Services.Models;
using System.Net.Http.Json;

namespace FintechBlazor.Services;

public class PixKeyService : IPixKeyService
{
    private readonly HttpClient _httpClient;

    public PixKeyService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RegisterPixKeyResponse?> CadastrarChaveAsync(RegisterPixKeyRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/pixkey", request);
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<RegisterPixKeyResponse>();
        return null;
    }

    public async Task<bool> DeletarChaveAsync(long id)
    {
        var response = await _httpClient.DeleteAsync($"api/pixkey/{id}");
        return response.IsSuccessStatusCode;
    }

    public async Task<List<RegisterPixKeyResponse>> GetChavesByUserIdAsync(long userId)
    {
        var response = await _httpClient.GetFromJsonAsync<List<RegisterPixKeyResponse>>($"api/pixkey/user/{userId}");
        return response ?? new List<RegisterPixKeyResponse>();
    }
}
