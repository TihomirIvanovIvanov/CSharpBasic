
const decimal nailonSqrtM = 1.5m;
const decimal paintPerL = 14.5m;
const decimal razreditelPerL = 5m;

const decimal additionalPaint = 1.10m;
const decimal additionalNailon = 2m;
const decimal bags = 0.4m;

var nailon = int.Parse(Console.ReadLine());
var paint = int.Parse(Console.ReadLine());
var razreditel = int.Parse(Console.ReadLine());
var hoursForMaistors = int.Parse(Console.ReadLine());

var totalNailon = (nailon + additionalNailon) * nailonSqrtM;
var totalPaint = paint * additionalPaint * paintPerL;
var totalRazreditel = razreditel * razreditelPerL;

var totalSum = totalNailon + totalPaint + totalRazreditel + bags;
var maistorsPerHour = totalSum * 30 / 100;

Console.WriteLine(hoursForMaistors * maistorsPerHour + totalSum);