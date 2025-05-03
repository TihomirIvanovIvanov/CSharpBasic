using System;

namespace RadiansToDegrees
{
    public class Program
    {
        public static void Main()
        { 
            
            var radians = double.Parse(Console.ReadLine());
            var degrees = radians * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}