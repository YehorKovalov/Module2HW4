using System;
using SafariPark.Models.Enums;

namespace SafariPark.Models
{
    public class Chordate : Animal
    {
        public string ChordStructure { get; set; }
        public string PharyngealSlitStructure { get; set; }
        public bool IsSocial { get; set; }
    }
}
