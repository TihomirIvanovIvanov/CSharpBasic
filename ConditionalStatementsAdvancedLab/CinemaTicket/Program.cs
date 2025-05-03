var dayOfWeek = Console.ReadLine();

Console.WriteLine(dayOfWeek == "Monday" ? 12 :
                 (dayOfWeek == "Tuesday" ? 12 :
                  dayOfWeek == "Wednesday" ? 14 :
                  dayOfWeek == "Thursday" ? 14 :
                  dayOfWeek == "Friday" ? 12 :
                  dayOfWeek == "Saturday" ? 16 :
                  16));