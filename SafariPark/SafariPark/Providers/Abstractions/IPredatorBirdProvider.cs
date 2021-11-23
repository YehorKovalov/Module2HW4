using SafariPark.Data.Entitites;

namespace SafariPark.Providers.Abstractions
{
    public interface IPredatorBirdProvider
    {
        PredatorBird[] GetAll();
        PredatorBird GetBirdById(int id);
    }
}
