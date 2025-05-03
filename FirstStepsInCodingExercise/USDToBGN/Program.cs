using System;

namespace USDToBGN
{
    public class Program
    {
        public static void Main()
        {
            const decimal curs = 1.79549m;

            var USD = decimal.Parse(Console.ReadLine());

            Console.WriteLine(USD * curs);
        }
    }
}