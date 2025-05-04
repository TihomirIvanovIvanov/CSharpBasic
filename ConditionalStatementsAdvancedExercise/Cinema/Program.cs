const decimal premiere = 12m;
const decimal normal = 7.5m;
const decimal discount = 5m;

var projection = Console.ReadLine();
var row = int.Parse(Console.ReadLine());
var col = int.Parse(Console.ReadLine());

Console.WriteLine(projection == "Premiere" ? $"{(row * col * premiere):F2}" :
                 (projection == "Normal" ? $"{(row * col * normal):F2}" :
                 $"{(row * col * discount):F2}"));
