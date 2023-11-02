using GalaxyQuest.Interfaces;
using GalaxyQuest.Models;

using System.Net.Http;
using System.Text.Json;
using System.Text;




namespace GalaxyQuest.Services
{
    public class PlanetService : IPlanetService
    {
        private static readonly HttpClient _httpClient;

        static PlanetService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://swapi.dev/api/")
            };
        }

        public string Name { get; private set; }
        public long Population { get; private set; }

        public async Task<List<Planet>> GetPlanets()
        {
            string apiEndpoint = "/Planets";
            var response = await _httpClient.GetAsync(apiEndpoint);
            response.EnsureSuccessStatusCode();
            var planets = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<List<Planet>>(planets,
             new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            var planets1 = new List<Planet>();

            foreach (var planet in result)
            {
                planets1.Add(planet);
            }


                return result;

        }

    }
}
