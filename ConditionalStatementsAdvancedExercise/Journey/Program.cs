const string summer = "summer";
const string winter = "winter";
const string camp = "Camp";
const string hotel = "Hotel";

var budget = double.Parse(Console.ReadLine());
var season = Console.ReadLine().ToLower();

var destination = string.Empty;
var accommodation = string.Empty;
var spentMoney = 0d;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == summer)
    {
        accommodation = camp;
        spentMoney = budget * 0.7d;
    }
    else if (season == winter)
    {
        accommodation = hotel;
        spentMoney = budget * 0.3d;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == summer)
    {
        accommodation = camp;
        spentMoney = budget * 0.6d;
    }
    else if(season == winter)
    {
        accommodation = hotel;
        spentMoney = budget * 0.2d;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    accommodation = hotel;
    spentMoney = budget * 0.1d;
}

Console.WriteLine($"Somewhere in {destination}\n{accommodation} - {(budget - spentMoney):F2}");