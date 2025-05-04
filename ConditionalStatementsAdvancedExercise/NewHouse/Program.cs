const string roses = "Roses";
const string dahlias = "Dahlias";
const string tulips = "Tulips";
const string narcissus = "Narcissus";
const string gladiolus = "Gladiolus";

var flower = Console.ReadLine();
var quantity = int.Parse(Console.ReadLine());
var budget = int.Parse(Console.ReadLine());

var pricePerFlower = decimal.MinValue;

switch (flower)
{
    case roses: pricePerFlower = 5m; break;
    case dahlias: pricePerFlower = 3.8m; break;
    case tulips: pricePerFlower = 2.8m; break;
    case narcissus: pricePerFlower = 3m; break;
    case gladiolus: pricePerFlower = 2.5m; break;
}

var totalPrice = pricePerFlower * quantity;

if (flower == roses && quantity > 80)
{
    totalPrice *= 0.9m;
}
if (flower == dahlias && quantity > 90)
{
    totalPrice *= 0.85m;
}
if (flower == tulips && quantity > 80)
{
    totalPrice *= 0.85m;
}
if (flower == narcissus && quantity < 120)
{
    totalPrice *= 1.15m;
}
if (flower == gladiolus && quantity < 80)
{
    totalPrice *= 1.2m;
}

var left = decimal.MinValue;
if (budget >= totalPrice)
{
    left = budget - totalPrice;
    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {left:F2} leva left.");
}
else
{
    left = totalPrice - budget;
    Console.WriteLine($"Not enough money, you need {left:F2} leva more.");
}