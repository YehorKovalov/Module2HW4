using System;
using SafariPark.Models;

namespace SafariPark.Helpers
{
    public static class AnimalArrayExtension
    {
        public static Animal[] AppendRange(this Animal[] array, Animal[] items)
        {
            if (items == null)
            {
                return null;
            }

            if (array == null)
            {
                array = Array.Empty<Animal>();
            }

            var currArrayIndex = 0;
            var resultArray = new Animal[array.Length + items.Length];
            foreach (var elem in array)
            {
                resultArray[currArrayIndex++] = elem;
            }

            foreach (var item in items)
            {
                resultArray[currArrayIndex++] = item;
            }

            return resultArray;
        }

        public static Animal FindAnimalByName(this Animal[] animals, string name)
        {
            if (animals == null)
            {
                return null;
            }

            foreach (var animal in animals)
            {
                if (string.Equals(animal.Name, name))
                {
                    return animal;
                }
            }

            return null;
        }
    }
}
