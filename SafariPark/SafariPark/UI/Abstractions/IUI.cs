using SafariPark.Models;

namespace SafariPark.UI.Abstractions
{
    public interface IUI
    {
        void StartingWords();
        void DisplaySectionAnimals(AnimalsSection section);
        void DisplayAnimal(Animal animal);
        void DisplayAnimals(Animal[] animals);
        void DisplayBadArguments();
        void DisplayNotFound();
        void DisplayOperationIsSuccessful();
        void DisplayEverySectionAnimalsSpeciesAmount(params SpeciesInfo[] speciesInfos);
    }
}
