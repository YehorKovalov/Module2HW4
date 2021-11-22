using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    public class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal a1, Animal a2)
        {
            return string.Compare(a1.Name, a2.Name);
        }
    }
}
