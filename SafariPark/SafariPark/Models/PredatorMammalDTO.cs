using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    public class PredatorMammalDTO : Mammal, IPredator
    {
        public string ClawsStructure { get; set; }
    }
}
