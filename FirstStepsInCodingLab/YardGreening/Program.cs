using System;

namespace YardGreening
{
    public class Program
    {
        public static void Main()
        {
            const double priceSqrt = 7.61;
            const int discount = 18;

            var sqrtMeters = double.Parse(Console.ReadLine());

            var finalPrice = sqrtMeters * priceSqrt;
            var totalDiscount = finalPrice * discount / 100;

            Console.WriteLine($"The final price is: {finalPrice - totalDiscount} lv.");
            Console.WriteLine($"The discount is: {totalDiscount} lv.");
        }
    }
}