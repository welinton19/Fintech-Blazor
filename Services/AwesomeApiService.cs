using FintechBlazor.Services.Models;
using System.Net.Http.Json;

namespace FintechBlazor.Services;

public class AwesomeApiService : IAwesomeApiService
{
    private readonly HttpClient _httpClient;

    public AwesomeApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AwesomeApiResponse?> GetCotacoesAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<AwesomeApiResponse>(
                "https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL,BTC-BRL");
        }
        catch
        {
            return null;
        }
    }
}
