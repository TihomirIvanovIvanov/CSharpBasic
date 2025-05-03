using System;

namespace DepositCalculator
{
    public class Program
    {
        public static void Main()
        {
            var depositAmount = decimal.Parse(Console.ReadLine());
            var months = int.Parse(Console.ReadLine());
            var yearProcentage = decimal.Parse(Console.ReadLine());

            var totalAmountWin = depositAmount + months * ((depositAmount * yearProcentage / 100) / 12);
            Console.WriteLine(totalAmountWin);
        }
    }
}