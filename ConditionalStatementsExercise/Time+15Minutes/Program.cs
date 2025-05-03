const int minutes = 15;

var hour = int.Parse(Console.ReadLine());
var minute = int.Parse(Console.ReadLine());

var totalMinutes = hour * 60 + minute + minutes;

Console.WriteLine(TimeSpan.FromMinutes(totalMinutes).ToString(@"h\:mm"));