using System;
using SafariPark.Helpers;
using SafariPark.Models;
using SafariPark.Providers.Abstractions;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class PredatorBirdServices : IPredatorBirdServices
    {
        private readonly IPredatorBirdProvider _birdProvider;

        public PredatorBirdServices(IPredatorBirdProvider birdProvider)
        {
            _birdProvider = birdProvider;
        }

        public PredatorBirdDTO[] GetAll()
        {
            var birds = _birdProvider.GetAll();
            if (birds == null)
            {
                return null;
            }

            var currentBirdIndex = 0;
            var birdsDTO = new PredatorBirdDTO[birds.Length];
            foreach (var bird in birds)
            {
                birdsDTO[currentBirdIndex++] = new PredatorBirdDTO()
                {
                    Id = bird.Id,
                    WingsStructure = bird.WingsStructure,
                    ChordStructure = bird.ChordStructure,
                    ClawsStructure = bird.ClawsStructure,
                    IsSocial = bird.IsSocial,
                    BeakType = bird.BeakType,
                    FeatherColor = bird.FeatherColor,
                    FeedingHabit = bird.FeedingHabit,
                    IsAbleToFly = bird.IsAbleToFly,
                    PharyngealSlitStructure = bird.PharyngealSlitStructure,
                    Name = bird.Name
                };
            }

            return birdsDTO;
        }

        public PredatorBirdDTO GetMammalById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            var bird = _birdProvider.GetBirdById(id);
            if (bird == null)
            {
                return null;
            }

            return new PredatorBirdDTO()
            {
                Id = bird.Id,
                WingsStructure = bird.WingsStructure,
                ChordStructure = bird.ChordStructure,
                ClawsStructure = bird.ClawsStructure,
                IsSocial = bird.IsSocial,
                BeakType = bird.BeakType,
                FeatherColor = bird.FeatherColor,
                FeedingHabit = bird.FeedingHabit,
                IsAbleToFly = bird.IsAbleToFly,
                PharyngealSlitStructure = bird.PharyngealSlitStructure,
                Name = bird.Name
            };
        }

        public PredatorBirdDTO[] TakePredatoryBirdsFromAnimals(Animal[] animals)
        {
            if (animals == null)
            {
                return null;
            }

            var currentIndex = 0;
            var result = new PredatorBirdDTO[animals.Length];
            foreach (var animal in animals)
            {
                if (animal is PredatorBirdDTO bird)
                {
                    result[currentIndex++] = bird;
                }
            }

            Array.Resize(ref result, currentIndex);
            return result;
        }
    }
}
