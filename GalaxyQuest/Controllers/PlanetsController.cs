using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        public IActionResult Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            
            
            return View(milkyWayPlanets);
        }
    }
}
