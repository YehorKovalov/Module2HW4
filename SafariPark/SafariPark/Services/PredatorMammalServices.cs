using System;
using SafariPark.Models;
using SafariPark.Providers.Abstractions;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class PredatorMammalServices : IPredatorMammalServices
    {
        private readonly IPredatorMammalProvider _mammalProvider;

        public PredatorMammalServices(IPredatorMammalProvider mammalProvider)
        {
            _mammalProvider = mammalProvider;
        }

        public PredatorMammalDTO[] GetAll()
        {
            var predatorMammals = _mammalProvider.GetAll();
            if (predatorMammals == null)
            {
                return null;
            }

            var currentMammalIndex = 0;
            var resultMammals = new PredatorMammalDTO[predatorMammals.Length];
            foreach (var mammal in predatorMammals)
            {
                resultMammals[currentMammalIndex++] = new PredatorMammalDTO()
                {
                    Id = mammal.Id,
                    Name = mammal.Name,
                    ChordStructure = mammal.ChordStructure,
                    ClawsStructure = mammal.ClawsStructure,
                    IsSocial = mammal.IsSocial,
                    PharyngealSlitStructure = mammal.PharyngealSlitStructure,
                    FeedingHabit = mammal.FeedingHabit,
                    HairColor = mammal.HairColor
                };
            }

            return resultMammals;
        }

        public PredatorMammalDTO GetMammalById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            var mammal = _mammalProvider.GetMammalById(id);
            return new PredatorMammalDTO()
            {
                Id = mammal.Id,
                Name = mammal.Name,
                ChordStructure = mammal.ChordStructure,
                ClawsStructure = mammal.ClawsStructure,
                IsSocial = mammal.IsSocial,
                PharyngealSlitStructure = mammal.PharyngealSlitStructure,
                FeedingHabit = mammal.FeedingHabit,
                HairColor = mammal.HairColor
            };
        }

        public PredatorMammalDTO[] TakePredatoryMammalsFromAnimals(Animal[] animals)
        {
            if (animals == null)
            {
                return null;
            }

            var currentIndex = 0;
            var result = new PredatorMammalDTO[animals.Length];
            foreach (var animal in animals)
            {
                if (animal is PredatorMammalDTO mammal)
                {
                    result[currentIndex++] = mammal;
                }
            }

            Array.Resize(ref result, currentIndex);
            return result;
        }
    }
}
