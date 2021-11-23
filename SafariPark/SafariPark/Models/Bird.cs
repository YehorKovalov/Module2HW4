using System.Drawing;
using SafariPark.Models.Enums;

namespace SafariPark.Models
{
    public class Bird : Chordate
    {
        public BeakType BeakType { get; set; }
        public string WingsStructure { get; set; }
        public bool IsAbleToFly { get; set; }
        public Color FeatherColor { get; set; }
    }
}
