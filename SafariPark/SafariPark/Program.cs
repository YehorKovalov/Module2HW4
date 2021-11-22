using Microsoft.Extensions.DependencyInjection;
using SafariPark.Controllers;
using SafariPark.Providers;
using SafariPark.Providers.Abstractions;
using SafariPark.Services;
using SafariPark.Services.Abstractions;
using SafariPark.UI;
using SafariPark.UI.Abstractions;

namespace SafariPark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
               .AddTransient<IPredatorBirdProvider, PredatorBirdProvider>()
               .AddSingleton<IPredatorBirdServices, PredatorBirdServices>()
               .AddTransient<IPredatorMammalProvider, PredatorMammalProvider>()
               .AddSingleton<IPredatorMammalServices, PredatorMammalServices>()
               .AddSingleton<IAnimalSectionServices, AnimalSectionServices>()
               .AddTransient<IUI, ConsoleManager>()
               .AddTransient<IHomeController, HomeController>()
               .AddTransient<Startup>()
               .BuildServiceProvider();

            var start = serviceProvider.GetService<Startup>();
            start.Run();
        }
    }
}
