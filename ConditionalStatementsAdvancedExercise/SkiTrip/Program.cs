var days = int.Parse(Console.ReadLine());
var room = Console.ReadLine();
var star = Console.ReadLine();

int nights = days - 1;
double pricePerNight = 0;
double discount = 0;

switch (room)
{
    case "room for one person":
        pricePerNight = 18.00;
        discount = 0;
        break;

    case "apartment":
        pricePerNight = 25.00;
        if (nights < 10)
            discount = 0.30;
        else if (nights <= 15)
            discount = 0.35;
        else
            discount = 0.50;
        break;

    case "president apartment":
        pricePerNight = 35.00;
        if (nights < 10)
            discount = 0.10;
        else if (nights <= 15)
            discount = 0.15;
        else
            discount = 0.20;
        break;
}

double totalPrice = nights * pricePerNight;
totalPrice -= totalPrice * discount;

if (star == "positive")
{
    totalPrice += totalPrice * 0.25;
}
else if (star == "negative")
{
    totalPrice -= totalPrice * 0.10;
}

Console.WriteLine($"{totalPrice:F2}");