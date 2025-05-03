var num = int.Parse(Console.ReadLine());
Console.WriteLine(num < 100 ? "Less than 100" : 
                 (num > 200 ? "Greater than 200" : 
                 "Between 100 and 200"));