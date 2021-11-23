using System;
using SafariPark.Helpers;
using SafariPark.Models;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class AnimalSectionServices : IAnimalSectionServices
    {
        private readonly IPredatorBirdServices _predatorBirdServices;
        private readonly IPredatorMammalServices _predatorMammalServices;
        public AnimalSectionServices(
            IPredatorBirdServices predatorBirdServices,
            IPredatorMammalServices predatorMammalServices)
        {
            _predatorBirdServices = predatorBirdServices;
            _predatorMammalServices = predatorMammalServices;
        }

        public bool AddAnimalsToSection(ref AnimalsSection section, Animal[] animals)
        {
            if (section == null || animals == null)
            {
                return false;
            }

            var result = section.Animals.AppendRange(animals);

            if (result == null)
            {
                return false;
            }

            section.Animals = result;
            section.Mammals = _predatorMammalServices.TakePredatoryMammalsFromAnimals(section.Animals);
            section.Birds = _predatorBirdServices.TakePredatoryBirdsFromAnimals(section.Animals);

            return true;
        }

        public Animal[] SortAnimalsByName(AnimalsSection section)
        {
            if (section == null || section.Animals == null)
            {
                return null;
            }

            var result = section.Animals;
            Array.Sort(result, new AnimalComparer());
            return result;
        }

        public Animal FindAnimalByName(AnimalsSection section, string name)
        {
            if (section == null || name == null)
            {
                return null;
            }

            var foundAnimal = section.Animals.FindAnimalByName(name);
            return foundAnimal;
        }

        public int GetBirdsAmount(AnimalsSection section)
        {
            return section.Birds == null ? 0 : section.Birds.Length;
        }

        public int GetMammalsAmount(AnimalsSection section)
        {
            return section.Mammals == null ? 0 : section.Mammals.Length;
        }
    }
}