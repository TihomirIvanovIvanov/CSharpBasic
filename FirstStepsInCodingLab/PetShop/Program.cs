using System;

namespace PetShop
{
    public class Program
    {
        public static void Main()
        {
            const double dogFood = 2.5;
            const int catFood = 4;

            var numberDogPack = int.Parse(Console.ReadLine());
            var numberCatPack = int.Parse(Console.ReadLine());

            var totalSum = dogFood * numberDogPack + catFood * numberCatPack;
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}