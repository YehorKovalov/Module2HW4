using SafariPark.Models;
using SafariPark.Services.Abstractions;
using SafariPark.UI.Abstractions;

namespace SafariPark.Controllers
{
    public class HomeController : IHomeController
    {
        private readonly IPredatorBirdServices _predatorBirdServices;
        private readonly IPredatorMammalServices _predatorMammalServices;
        private readonly IUI _uI;
        private readonly IAnimalSectionServices _animalSectionServices;
        public HomeController(
            IPredatorBirdServices predatorBirdServices,
            IPredatorMammalServices predatorMammalServices,
            IUI uI,
            IAnimalSectionServices animalSectionServices)
        {
            _predatorBirdServices = predatorBirdServices;
            _predatorMammalServices = predatorMammalServices;
            _uI = uI;
            _animalSectionServices = animalSectionServices;
        }

        public AnimalsSection GetNewSection()
        {
            return new AnimalsSection();
        }

        public PredatorBirdDTO[] GetPredatoryBirds()
        {
            var result = _predatorBirdServices.GetAll();
            if (result == null)
            {
                _uI.DisplayNotFound();
                return null;
            }

            return result;
        }

        public PredatorMammalDTO[] GetPredatoryMammals()
        {
            var result = _predatorMammalServices.GetAll();
            if (result == null)
            {
                _uI.DisplayNotFound();
                return null;
            }

            return result;
        }

        public void AddingAnimalsToSection(ref AnimalsSection animalsSection, Animal[] animals)
        {
            if (animalsSection == null || animals == null)
            {
                _uI.DisplayBadArguments();
                return;
            }

            var isSucceed = _animalSectionServices.AddAnimalsToSection(ref animalsSection, animals);
            if (!isSucceed)
            {
                _uI.DisplayNotFound();
                return;
            }

            _uI.DisplayOperationIsSuccessful();
        }

        public void SortingAnimalsInSectionByName(AnimalsSection animalsSection)
        {
            if (animalsSection == null)
            {
                _uI.DisplayBadArguments();
                return;
            }

            var sortedAnimals = _animalSectionServices.SortAnimalsByName(animalsSection);
            if (sortedAnimals == null)
            {
                _uI.DisplayNotFound();
                return;
            }

            _uI.DisplayOperationIsSuccessful();
            _uI.DisplayAnimals(sortedAnimals);
        }

        public void FindingAnimalByName(AnimalsSection animalsSection, string name)
        {
            if (animalsSection == null)
            {
                _uI.DisplayBadArguments();
                return;
            }

            var foundAnimal = _animalSectionServices.FindAnimalByName(animalsSection, name);
            if (foundAnimal == null)
            {
                _uI.DisplayNotFound();
                return;
            }

            _uI.DisplayOperationIsSuccessful();
            _uI.DisplayAnimal(foundAnimal);
        }

        public void ShowingEverySpeciesAmount(AnimalsSection section)
        {
            if (section == null)
            {
                _uI.DisplayBadArguments();
                return;
            }

            var speciesInfos = new SpeciesInfo[]
            {
                new SpeciesInfo
                {
                    SpeciesAmount = section.Birds.Length,
                    AnimalSpeciesName = "Birds"
                },
                new SpeciesInfo
                {
                    SpeciesAmount = section.Mammals.Length,
                    AnimalSpeciesName = "Mammals"
                }
            };
            _uI.DisplayEverySectionAnimalsSpeciesAmount(speciesInfos);
        }
    }
}
