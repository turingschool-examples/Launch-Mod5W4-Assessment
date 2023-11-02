using GalaxyQuest.Models;

namespace GalaxyQuest.Interfaces
{
    public interface ISwapiService
    {
        Task<List<Planet>> GetPlanetsAsync();
    }
}
