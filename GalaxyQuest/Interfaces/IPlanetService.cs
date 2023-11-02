using GalaxyQuest.Models;
using GalaxyQuest.Services;

namespace GalaxyQuest.Interfaces

{
    public interface IPlanetService
    {
        Task<List<Planet>> GetPlanets();
    }
}
