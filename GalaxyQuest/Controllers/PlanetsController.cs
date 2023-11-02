using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;
using GalaxyQuest.Models;
using GalaxyQuest.Interfaces;
using GalaxyQuest.Services;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        
        private readonly IPlanetService _planetService;

        public PlanetsController(ILogger<HomeController>logger, IPlanetService planetService)
        {
            
            _planetService = planetService;
        }
        public IActionResult Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
          // var planets = await _planetService.GetPlanets();

           
            return View(milkyWayPlanets);
        }
    }
}
