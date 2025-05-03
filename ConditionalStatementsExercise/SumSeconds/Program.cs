var firstTime = int.Parse(Console.ReadLine());
var secondTime = int.Parse(Console.ReadLine());
var thirtTime = int.Parse(Console.ReadLine());

var totalTime = firstTime + secondTime + thirtTime;
Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(@"m\:ss"));