var fruit = Console.ReadLine();
var day = Console.ReadLine();
var quantity = decimal.Parse(Console.ReadLine());

var price = 0.0m;
var isValid = true;

var isWeekday = day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                 day == "Thursday" || day == "Friday";
var isWeekend = day == "Saturday" || day == "Sunday";

if (isWeekday)
{
    switch (fruit)
    {
        case "banana": price = 2.50m; break;
        case "apple": price = 1.20m; break;
        case "orange": price = 0.85m; break;
        case "grapefruit": price = 1.45m; break;
        case "kiwi": price = 2.70m; break;
        case "pineapple": price = 5.50m; break;
        case "grapes": price = 3.85m; break;
        default: isValid = false; break;
    }
}
else if (isWeekend)
{
    switch (fruit)
    {
        case "banana": price = 2.70m; break;
        case "apple": price = 1.25m; break;
        case "orange": price = 0.90m; break;
        case "grapefruit": price = 1.60m; break;
        case "kiwi": price = 3.00m; break;
        case "pineapple": price = 5.60m; break;
        case "grapes": price = 4.20m; break;
        default: isValid = false; break;
    }
}
else
{
    isValid = false;
}

if (isValid)
{
    var total = price * quantity;
    Console.WriteLine($"{total:F2}");
}
else
{
    Console.WriteLine("error");
}