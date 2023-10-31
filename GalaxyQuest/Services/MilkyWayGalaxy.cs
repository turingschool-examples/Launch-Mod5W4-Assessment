using GalaxyQuest.Models;

namespace GalaxyQuest.Services
{
    public class MilkyWayGalaxy
    {
        static public List<Planet> Planets = new List<Planet>() {
            new Planet() { Name = "Mercury", Population = 1 },
            new Planet() { Name = "Venus", Population = 2 },
            new Planet() { Name = "Earth", Population = 7_888_000_000 },
            new Planet() { Name = "Mars", Population = 3 },
            new Planet() { Name = "Jupiter", Population = 1 },
            new Planet() { Name = "Saturn", Population = 1 },
            new Planet() { Name = "Uranus", Population = 0 },
            new Planet() { Name = "Neptune", Population = 0 }
        };
    }
}
