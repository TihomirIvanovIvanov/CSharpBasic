var length = int.Parse(Console.ReadLine());
var width = int.Parse(Console.ReadLine());
var height = int.Parse(Console.ReadLine());
var procentage = double.Parse(Console.ReadLine());

var volumeSqrtM = length *  width * height;
var volumeLiters = volumeSqrtM / 1000d;
var realVolumeLitre = volumeLiters * (1 - procentage / 100d);

Console.WriteLine($"{realVolumeLitre:F3}");