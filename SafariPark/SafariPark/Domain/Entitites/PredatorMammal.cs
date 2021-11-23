using System.Drawing;
using SafariPark.Models.Enums;

namespace SafariPark.Data.Entitites
{
    public class PredatorMammal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FeedingHabit FeedingHabit { get; set; }
        public string ChordStructure { get; set; }
        public string PharyngealSlitStructure { get; set; }
        public bool IsSocial { get; set; }
        public Color HairColor { get; set; }
        public string ClawsStructure { get; set; }
    }
}
