using System.Collections;
using SafariPark.Models.Enums;

namespace SafariPark.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FeedingHabit FeedingHabit { get; set; }
    }
}
