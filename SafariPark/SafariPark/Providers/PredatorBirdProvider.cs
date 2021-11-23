using System.Drawing;
using SafariPark.Data.Entitites;
using SafariPark.Providers.Abstractions;
using SafariPark.Models.Enums;

namespace SafariPark.Providers
{
    public class PredatorBirdProvider : IPredatorBirdProvider
    {
        public PredatorBird[] GetAll()
        {
            return new PredatorBird[]
            {
                new PredatorBird
                {
                    Id = 1,
                    Name = "Vulture",
                    ChordStructure = "Vulture's chord structure",
                    ClawsStructure = "Vulture' claws structure",
                    PharyngealSlitStructure = "Vulture's pharyngeal slit structure",
                    WingsStructure = "Vulture's wings structure",
                    IsSocial = true,
                    BeakType = BeakType.Hooked,
                    FeatherColor = Color.DarkGray,
                    FeedingHabit = FeedingHabit.Carnivorous,
                    IsAbleToFly = true
                },
                new PredatorBird
                {
                    Id = 2,
                    Name = "Hawk",
                    ChordStructure = "Hawk's chord structure",
                    ClawsStructure = "Hawk' claws structure",
                    PharyngealSlitStructure = "Hawk's pharyngeal slit structure",
                    WingsStructure = "Hawk's wings structure",
                    IsSocial = true,
                    BeakType = BeakType.Hooked,
                    FeatherColor = Color.DarkGray,
                    FeedingHabit = FeedingHabit.Carnivorous,
                    IsAbleToFly = true
                },
                new PredatorBird
                {
                    Id = 3,
                    Name = "Eagle",
                    ChordStructure = "Eagle's chord structure",
                    ClawsStructure = "Eagle' claws structure",
                    PharyngealSlitStructure = "Eagle's pharyngeal slit structure",
                    WingsStructure = "Eagle's wings structure",
                    IsSocial = true,
                    BeakType = BeakType.Hooked,
                    FeatherColor = Color.Brown,
                    FeedingHabit = FeedingHabit.Carnivorous,
                    IsAbleToFly = true
                }
            };
        }

        public PredatorBird GetBirdById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            PredatorBird resultBird = null;
            foreach (var bird in GetAll())
            {
                if (bird.Id == id)
                {
                    resultBird = bird;
                }
            }

            return resultBird;
        }
    }
}
