var examHour = int.Parse(Console.ReadLine());
var examMinute = int.Parse(Console.ReadLine());
var arriveHour = int.Parse(Console.ReadLine());
var arriveMinute = int.Parse(Console.ReadLine());

var examTotalMinutes = examHour * 60 + examMinute;
var arriveTotalMinutes = arriveHour * 60 + arriveMinute;

var difference = arriveTotalMinutes - examTotalMinutes;

if (difference > 0)
{
    Console.WriteLine("Late");
    if (difference < 60)
    {
        Console.WriteLine($"{difference} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{difference / 60}:{difference % 60:D2} hours after the start");
    }
}
else if (difference >= -30)
{
    Console.WriteLine("On time");
    if (difference != 0)
    {
        Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
    }
}
else
{
    Console.WriteLine("Early");
    if (Math.Abs(difference) < 60)
    {
        Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60:D2} hours before the start");
    }
}