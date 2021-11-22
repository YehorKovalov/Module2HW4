using SafariPark.Data.Entitites;

namespace SafariPark.Providers.Abstractions
{
    public interface IPredatorMammalProvider
    {
        PredatorMammal[] GetAll();
        PredatorMammal GetMammalById(int id);
    }
}
