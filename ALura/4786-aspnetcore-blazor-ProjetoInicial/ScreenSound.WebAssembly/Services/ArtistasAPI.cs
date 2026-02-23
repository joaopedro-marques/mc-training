using ScreenSound.Shared.Modelos.Response;

namespace ScreenSound.WebAssembly.Services;


public class ArtistasAPI {
    
    private readonly HttpClient _httpClient;

    public ArtistasAPI (IHttpClientFactory factory)
    {

        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<ArtistaResponse>> GetArtistasAsync()
    {
        return await HttpClient.GetFromJsonAsync<ICollection<ArtistaResponse>>("artistas");
    }
}