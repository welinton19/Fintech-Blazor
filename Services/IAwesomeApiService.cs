using FintechBlazor.Services.Models;

namespace FintechBlazor.Services;

public interface IAwesomeApiService
{
    Task<AwesomeApiResponse?> GetCotacoesAsync();
}
