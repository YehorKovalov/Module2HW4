using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    public class AnimalsSection
    {
        public Animal[] Animals { get; set; }
        public Bird[] Birds { get; set; }
        public Mammal[] Mammals { get; set; }
    }
}
