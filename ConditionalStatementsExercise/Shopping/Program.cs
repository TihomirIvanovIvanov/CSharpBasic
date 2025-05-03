var budget = double.Parse(Console.ReadLine());
var n = int.Parse(Console.ReadLine());
var m = int.Parse(Console.ReadLine());
var p = int.Parse(Console.ReadLine());

var nPrice = 250d;
var nSum = n * nPrice;

var mPrice = nSum * 35 / 100;
var mSum = m * mPrice;

var pPrice = nSum * 10 / 100;
var pSum = p * pPrice;

var totalSum = nSum + mSum + pSum;

if (n > m)
{
    totalSum -= totalSum * 15 / 100;
}

Console.WriteLine(budget >= totalSum ? 
    $"You have {(budget - totalSum):F2} leva left!" :          
    $"Not enough money! You need {(totalSum - budget):F2} leva more!");