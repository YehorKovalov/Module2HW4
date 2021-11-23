using System.Drawing;
using SafariPark.Models.Enums;

namespace SafariPark.Data.Entitites
{
    public class PredatorBird
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FeedingHabit FeedingHabit { get; set; }
        public Color FeatherColor { get; set; }
        public string ChordStructure { get; set; }
        public string PharyngealSlitStructure { get; set; }
        public bool IsSocial { get; set; }
        public string ClawsStructure { get; set; }
        public BeakType BeakType { get; set; }
        public string WingsStructure { get; set; }
        public bool IsAbleToFly { get; set; }
    }
}
