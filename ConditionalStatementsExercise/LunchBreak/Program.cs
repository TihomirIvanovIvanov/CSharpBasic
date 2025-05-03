var serial = Console.ReadLine();
var epizodeMinutes = int.Parse(Console.ReadLine());
var lunchBreakMinutes = int.Parse(Console.ReadLine());

var lunchBreak = lunchBreakMinutes / 1d / 8d;
var restBreak = lunchBreakMinutes / 1d / 4d;
var timeLeft = lunchBreakMinutes - lunchBreak - restBreak;

Console.WriteLine(timeLeft >= epizodeMinutes ? 
                 $"You have enough time to watch {serial} and left with {Math.Ceiling(timeLeft - epizodeMinutes)} minutes free time." :
                 $"You don't have enough time to watch {serial}, you need {Math.Ceiling(epizodeMinutes - timeLeft)} more minutes.");