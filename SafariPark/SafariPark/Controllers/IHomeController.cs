using SafariPark.Models;

namespace SafariPark.Controllers
{
    public interface IHomeController
    {
        void AddingAnimalsToSection(ref AnimalsSection animalsSection, Animal[] animals);
        void FindingAnimalByName(AnimalsSection animalsSection, string name);
        AnimalsSection GetNewSection();
        PredatorBirdDTO[] GetPredatoryBirds();
        PredatorMammalDTO[] GetPredatoryMammals();
        void SortingAnimalsInSectionByName(AnimalsSection animalsSection);
        void ShowingEverySpeciesAmount(AnimalsSection section);
    }
}