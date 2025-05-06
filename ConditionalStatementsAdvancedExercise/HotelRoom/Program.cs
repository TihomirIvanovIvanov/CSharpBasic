const string may = "May";
const string october = "October";
const string june = "June";
const string sept = "September";
const string july = "July";
const string aug = "August";

var month = Console.ReadLine();
var nights = int.Parse(Console.ReadLine());

var studioPrice = 0d;
var apartament = 0d;

switch (month)
{
    case may: case october:
        studioPrice = 50d;
        apartament = 65d;
        break;
    case june: case sept:
        studioPrice = 75.2d;
        apartament = 68.7d;
        break;
    case july: case aug:
        studioPrice = 76d;
        apartament = 77d;
        break;
    default:
		break;
}

if (nights > 7 && nights < 14 && (month == may || month == october))
{
    studioPrice -= studioPrice * 5 / 100;
}
if (nights > 14 && (month == may || month == october))
{
    studioPrice -= studioPrice * 30 / 100;
}
if (nights > 14 && (month == june || month == sept))
{
    studioPrice -= studioPrice * 20 / 100;
}
if (nights > 14)
{
    apartament -= apartament * 10 / 100;
}

var studioResult = nights * studioPrice;
var apartResult = nights * apartament;

Console.WriteLine($"Apartment: {apartResult:F2} lv.");
Console.WriteLine($"Studio: {studioResult:F2} lv.");