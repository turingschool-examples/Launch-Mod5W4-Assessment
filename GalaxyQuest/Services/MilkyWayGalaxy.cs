using GalaxyQuest.Models;

namespace GalaxyQuest.Services
{
    public class MilkyWayGalaxy
    {
        static public List<Planet> Planets = new List<Planet>() {
            new Planet() { Name = "Mercury", NotableResidents = { "Messenger" } },
            new Planet() { Name = "Venus", NotableResidents = { "Pioneer Venus", "Vega" } },
            new Planet() { Name = "Earth", NotableResidents = { "Zoe Farrell", "Megan McMahon", "Eric Weissman"} },
            new Planet() { Name = "Mars", NotableResidents = { "Rover", "Pathfinder", "Mark Watney" } },
            new Planet() { Name = "Jupiter", NotableResidents = { "Galileo" } },
            new Planet() { Name = "Saturn", NotableResidents = { "Huygens Probe" } },
            new Planet() { Name = "Uranus", NotableResidents = new List<string> () },
            new Planet() { Name = "Neptune", NotableResidents = new List<string> () }
        
        };
    }
}
