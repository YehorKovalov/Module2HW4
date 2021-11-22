using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    public class PredatorBirdDTO : Bird, IPredator
    {
        public string ClawsStructure { get; set; }
    }
}
