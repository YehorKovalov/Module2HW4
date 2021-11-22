using System.Drawing;
using SafariPark.Data.Entitites;
using SafariPark.Models.Enums;
using SafariPark.Providers.Abstractions;

namespace SafariPark.Providers
{
    public class PredatorMammalProvider : IPredatorMammalProvider
    {
        public PredatorMammal[] GetAll()
        {
            return new PredatorMammal[]
            {
                new PredatorMammal()
                {
                    Id = 4,
                    Name = "Cougar",
                    ChordStructure = "Cougar's chord structure",
                    HairColor = Color.IndianRed,
                    IsSocial = true,
                    FeedingHabit = FeedingHabit.Carnivorous,
                    PharyngealSlitStructure = "Cougar's pharyngeal slit structure",
                    ClawsStructure = "Leopard's claws structure"
                },

                new PredatorMammal()
                {
                    Id = 5,
                    Name = "Leopard",
                    ChordStructure = "Leopard's chord structure",
                    PharyngealSlitStructure = "Leopard's pharyngeal slit structure",
                    IsSocial = true,
                    ClawsStructure = "Leopard's claws structure",
                    FeedingHabit = FeedingHabit.Carnivorous,
                    HairColor = Color.LightGoldenrodYellow
                },

                new PredatorMammal()
                {
                    Id = 6,
                    Name = "White wolf",
                    ChordStructure = "White wolf's chord structure",
                    PharyngealSlitStructure = "White wolf's pharyngeal slit structure",
                    IsSocial = true,
                    ClawsStructure = "White wolf's claws structure",
                    FeedingHabit = FeedingHabit.Carnivorous,
                    HairColor = Color.WhiteSmoke
                }
            };
        }

        public PredatorMammal GetMammalById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            PredatorMammal resultMammal = null;
            foreach (var mammal in GetAll())
            {
                if (mammal.Id == id)
                {
                    resultMammal = mammal;
                }
            }

            return resultMammal;
        }
    }
}
