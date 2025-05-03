var dayOfWeek = int.Parse(Console.ReadLine());

Console.WriteLine(dayOfWeek == 1 ? "Monday" :
                 (dayOfWeek == 2 ? "Tuesday" :
                 dayOfWeek == 3 ? "Wednesday" :
                 dayOfWeek == 4 ? "Thursday" :
                 dayOfWeek == 5 ? "Friday" :
                 dayOfWeek == 6 ? "Saturday" :
                 dayOfWeek == 7 ? "Sunday" :
                 "Error"));