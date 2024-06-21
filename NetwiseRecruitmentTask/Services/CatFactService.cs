using NetwiseRecruitmentTask.Abstractions;
using NetwiseRecruitmentTask.Models;

public class CatFactService : ICatFactService
{
    private readonly HttpClient _httpClient;

    public CatFactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CatFactModel> GetCatFactAsync()
    {
        var catFactResponse = await _httpClient.GetFromJsonAsync<CatFactModel>("https://catfact.ninja/fact");

        if (catFactResponse == null)
        {
            throw new Exception("Received null response from cat facts API");
        }

        var catFact = new CatFactModel
        {
            Fact = catFactResponse.Fact,
            Length = catFactResponse.Length
        };

        return catFact;
    }
}