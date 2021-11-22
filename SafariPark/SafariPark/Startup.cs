using SafariPark.Controllers;
using SafariPark.UI.Abstractions;

namespace SafariPark
{
    public class Startup
    {
        private readonly IUI _uI;
        private readonly IHomeController _homeController;

        public Startup(IUI uI, IHomeController homeController)
        {
            _uI = uI;
            _homeController = homeController;
        }

        public void Run()
        {
            _uI.StartingWords();
            var predatoryBirds = _homeController.GetPredatoryBirds();
            var predatoyMammals = _homeController.GetPredatoryMammals();
            var section = _homeController.GetNewSection();
            _homeController.AddingAnimalsToSection(ref section, predatoyMammals);
            _homeController.AddingAnimalsToSection(ref section, predatoryBirds);
            _homeController.SortingAnimalsInSectionByName(section);
            _homeController.FindingAnimalByName(section, "Vulture");
            _homeController.ShowingEverySpeciesAmount(section);
        }
    }
}
