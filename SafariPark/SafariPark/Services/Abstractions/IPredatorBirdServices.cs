using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface IPredatorBirdServices
    {
        PredatorBirdDTO[] GetAll();
        PredatorBirdDTO GetMammalById(int id);
        PredatorBirdDTO[] TakePredatoryBirdsFromAnimals(Animal[] animals);
    }
}
