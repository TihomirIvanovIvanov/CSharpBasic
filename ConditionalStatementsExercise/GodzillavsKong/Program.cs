const decimal decorDisc = 10m;
const decimal outfitDisc = 10m;

var budget = decimal.Parse(Console.ReadLine());
var stats = int.Parse(Console.ReadLine());
var oneStatOutfitPrice = decimal.Parse(Console.ReadLine());

var decor = budget * decorDisc / 100;

if (stats > 150)
{
    oneStatOutfitPrice -= oneStatOutfitPrice * outfitDisc / 100;
}

var totalCost = decor + oneStatOutfitPrice * stats;

if (totalCost > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(totalCost - budget):F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {(budget - totalCost):F2} leva left.");
}