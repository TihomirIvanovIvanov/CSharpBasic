using System;

namespace VacationBooksList
{
    public class Program
    {
        public static void Main()
        {
            var totalPagesCurrentBook = int.Parse(Console.ReadLine());
            var readedPagesPerHour = int.Parse(Console.ReadLine());
            var totalReedingDays = int.Parse(Console.ReadLine());

            Console.WriteLine(totalPagesCurrentBook / readedPagesPerHour / totalReedingDays);
        }
    }
}