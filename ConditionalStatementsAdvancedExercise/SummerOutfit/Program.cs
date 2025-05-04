var degree = int.Parse(Console.ReadLine());
var timeOfDay = Console.ReadLine();

if (timeOfDay == "Morning")
{
	if (degree >= 10 && degree <= 18)
	{
        Console.WriteLine($"It's {degree} degrees, get your Sweatshirt and Sneakers.");
	}
	else if (degree > 18 && degree <= 24)
	{
        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
    }
	else if(degree > 24)
	{
        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
    }
}
else if (timeOfDay == "Afternoon")
{
    if (degree >= 10 && degree <= 18)
    {
        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
    }
    else if (degree > 18 && degree <= 24)
    {
        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
    }
    else if (degree > 24)
    {
        Console.WriteLine($"It's {degree} degrees, get your Swim Suit and Barefoot.");
    }
}
else if (timeOfDay == "Evening")
{
    if (degree >= 10 && degree <= 18)
    {
        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
    }
    else if (degree > 18 && degree <= 24)
    {
        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
    }
    else if (degree > 24)
    {
        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
    }
}