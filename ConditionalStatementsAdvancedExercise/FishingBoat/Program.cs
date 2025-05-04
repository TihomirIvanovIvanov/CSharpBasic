const string spring = "Spring";
const string summer = "Summer";
const string autumn = "Autumn";
const string winter = "Winter";

var budget = int.Parse(Console.ReadLine());
var season = Console.ReadLine();
var fishermanCount = int.Parse(Console.ReadLine());

double boatPrice = 0;

switch (season)
{
    case spring: boatPrice = 3000; break;
    case summer: case autumn: 
        boatPrice = 4200; break;
    case winter: boatPrice = 2600; break;
}

if (fishermanCount <= 6)
{
    boatPrice *= 0.9;
}
if (fishermanCount >= 7 && fishermanCount <= 11)
{
    boatPrice *= 0.85;
}
if (fishermanCount > 11)
{
    boatPrice *= 0.75;
}

if (fishermanCount % 2 == 0 && season != autumn)
{
    boatPrice *= 0.95;
}

var left = budget - boatPrice;

if (left >= 0)
{   
    Console.WriteLine($"Yes! You have {left:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(left):F2} leva.");
}