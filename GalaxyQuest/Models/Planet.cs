namespace GalaxyQuest.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public List<string> NotableResidents { get; set; } = new List<string>();
    }
}
