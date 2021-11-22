using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface IAnimalSectionServices
    {
        bool AddAnimalsToSection(ref AnimalsSection section, Animal[] newAnimal);
        Animal[] SortAnimalsByName(AnimalsSection section);
        Animal FindAnimalByName(AnimalsSection section, string name);
    }
}