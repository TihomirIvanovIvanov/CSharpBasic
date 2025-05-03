var age = double.Parse(Console.ReadLine());
var gender = char.Parse(Console.ReadLine());

Console.WriteLine((age >= 16d && gender == 'm') ? "Mr." :
                 ((age < 16d && gender == 'm') ? "Master" :
                  (age >= 16d && gender == 'f') ? "Ms." :
                  "Miss"));

