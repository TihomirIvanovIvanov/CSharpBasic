
const decimal pencilPack = 5.8m;
const decimal markersPack = 7.2m;
const decimal cleaningPerLitre = 1.2m;

var totalPackPencil = int.Parse(Console.ReadLine());
var totalPackMarkers = int.Parse(Console.ReadLine());
var totalLitres =  int.Parse(Console.ReadLine());
var discountProcentage =  int.Parse(Console.ReadLine());

var totalCost = totalPackPencil * pencilPack + totalPackMarkers * markersPack + totalLitres * cleaningPerLitre;
var totalDiscount = totalCost * discountProcentage / 100;
Console.WriteLine(totalCost - totalDiscount);