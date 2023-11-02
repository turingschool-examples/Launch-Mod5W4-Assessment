using GalaxyQuest.Interfaces;
using GalaxyQuest.Services;
using GalaxyQuest.Models;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly ISwapiService _swapiService;

        public PlanetsController(ISwapiService swapiService)
        {
            _swapiService = swapiService;
        }

        public IActionResult Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            
            return View(milkyWayPlanets);
        }

        public async Task<IActionResult> FarFarAwayIndex()
        {
            List<Planet> farFarAwayPlanets = new List<Planet>();
            farFarAwayPlanets = await _swapiService.GetPlanetsAsync();
            return View(farFarAwayPlanets);
        }
    }
}
