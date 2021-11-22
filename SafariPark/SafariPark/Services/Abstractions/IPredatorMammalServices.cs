using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface IPredatorMammalServices
    {
        PredatorMammalDTO[] GetAll();
        PredatorMammalDTO GetMammalById(int id);
        PredatorMammalDTO[] TakePredatoryMammalsFromAnimals(Animal[] animals);
    }
}
