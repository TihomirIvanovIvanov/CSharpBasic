var dayOfWeek = Console.ReadLine();

Console.WriteLine(dayOfWeek == "Monday" ? "Working day" :
                 (dayOfWeek == "Tuesday" ? "Working day" :
                  dayOfWeek == "Wednesday" ? "Working day" :
                  dayOfWeek == "Thursday" ? "Working day" :
                  dayOfWeek == "Friday" ? "Working day" :
                  dayOfWeek == "Saturday" ? "Weekend" :
                  dayOfWeek == "Sunday" ? "Weekend" :
                  "Error"));