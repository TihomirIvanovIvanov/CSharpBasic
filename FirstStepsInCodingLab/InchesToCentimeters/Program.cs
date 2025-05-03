using System;

namespace InchesToCentimeters
{
    public class Program
    {
        public static void Main()
        {
            const double inch = 2.54;
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine(num * inch);
        }
    }
}