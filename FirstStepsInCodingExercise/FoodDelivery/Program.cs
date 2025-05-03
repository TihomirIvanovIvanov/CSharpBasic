
const decimal chicken = 10.35m;
const decimal fish = 12.40m;
const decimal veggie = 8.15m;
const decimal delivery = 2.5m;
const decimal desertFee = 20m;

var chMenu = int.Parse(Console.ReadLine());
var fiMenu = int.Parse(Console.ReadLine());
var veMenu = int.Parse(Console.ReadLine());

var totalSum = chMenu * chicken +
               fiMenu * fish +
               veMenu * veggie;

var desertCost = totalSum * desertFee / 100;

totalSum += desertCost + delivery;

Console.WriteLine(totalSum);

