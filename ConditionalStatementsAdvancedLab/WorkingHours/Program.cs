var hour = int.Parse(Console.ReadLine());
var dayOfWeek = Console.ReadLine();

Console.WriteLine((dayOfWeek == "Monday" && (hour >= 10 && hour <= 18))  ? "open" :
                 ((dayOfWeek == "Tuesday" && (hour >= 10 && hour <= 18) ? "open" :
                  dayOfWeek == "Wednesday" && (hour >= 10 && hour <= 18) ? "open" :
                  dayOfWeek == "Thursday" && (hour >= 10 && hour <= 18)  ? "open" :
                  dayOfWeek == "Friday" && (hour >= 10 && hour <= 18) ? "open" :
                  dayOfWeek == "Saturday" && (hour >= 10 && hour <= 18) ? "open" :
                  "closed")));