using System;

namespace ProjectsCreation
{
    public class Program
    {
        public static void Main()
        {
            const int neededHour = 3;

            var architectName = Console.ReadLine();
            var numberOfProjects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {architectName} will need {neededHour * numberOfProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}