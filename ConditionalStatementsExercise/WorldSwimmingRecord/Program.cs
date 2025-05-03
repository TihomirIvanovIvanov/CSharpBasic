var worldRecord = double.Parse(Console.ReadLine());
var distanceInM = double.Parse(Console.ReadLine());
var timeInSecPerM = double.Parse(Console.ReadLine());

var baseTime = distanceInM * timeInSecPerM;
var delay = Math.Floor(distanceInM / 15) * 12.5d;
var totalTime = baseTime + delay;

if (totalTime < worldRecord)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {(totalTime - worldRecord):F2} seconds slower.");
}