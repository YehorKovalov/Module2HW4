using System;
using SafariPark.Data.Entitites;
using SafariPark.Models;
using SafariPark.UI.Abstractions;

namespace SafariPark.UI
{
    public class ConsoleManager : IUI
    {
        private readonly string _whiteSpaces = new string(string.Empty).PadLeft(10);

        public void DisplayAnimal(Animal animal)
        {
            Console.WriteLine($"{animal.Id}{_whiteSpaces}{animal.Name}{_whiteSpaces}{animal.FeedingHabit}");
        }

        public void DisplayAnimals(Animal[] animals)
        {
            Console.WriteLine($"Id{_whiteSpaces}Name{_whiteSpaces}Feeding Habit");

            foreach (var animal in animals)
            {
                DisplayAnimal(animal);
            }
        }

        public void DisplayBadArguments()
        {
            Console.WriteLine("Bad arguments");
        }

        public void DisplayEverySectionAnimalsSpeciesAmount(params SpeciesInfo[] speciesInfos)
        {
            foreach (var info in speciesInfos)
            {
                Console.WriteLine($"{info.AnimalSpeciesName}: {info.SpeciesAmount}");
            }
        }

        public void DisplayNotFound()
        {
            Console.WriteLine("Not found");
        }

        public void DisplayOperationIsSuccessful()
        {
            Console.WriteLine("Success!");
        }

        public void DisplaySectionAnimals(AnimalsSection section)
        {
            DisplayAnimals(section.Animals);
        }

        public void StartingWords()
        {
            Console.WriteLine("Welcome to our safari zoo!");
        }
    }
}
