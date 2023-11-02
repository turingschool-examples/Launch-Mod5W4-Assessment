using GalaxyQuest.Interfaces;
using GalaxyQuest.Models;
using System.Text.Json;
using System.Net.Http;

namespace GalaxyQuest.Services
{
    public class SwapiService : ISwapiService
    {
        private readonly HttpClient _httpClient;

        public SwapiService()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://swapi.dev/api/") };
        }

        public async Task<List<Planet>> GetPlanetsAsync()
        {
            try
            {
                string apiEndpoint = "planets";
                var response = await _httpClient.GetAsync(apiEndpoint);
                response.EnsureSuccessStatusCode();
                var planets = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<PlanetResponse>(planets,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

                return result.Planets;
            }
            catch (HttpRequestException ex)
            {
                // Handle any HTTP request errors here, such as logging or rethrowing.
                throw;
            }
        }
        private class PlanetResponse
        {
            public List<Planet> Planets { get; set; }
        }
    }
}



