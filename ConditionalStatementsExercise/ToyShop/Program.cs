const decimal puzzle = 2.60m;
const decimal doll = 3m;
const decimal bear = 4.10m;
const decimal minion = 8.20m;
const decimal truck = 2m;

var tripPrice = decimal.Parse(Console.ReadLine());
var puzzleCount = int.Parse(Console.ReadLine());
var dollCount = int.Parse(Console.ReadLine());
var bearCount = int.Parse(Console.ReadLine());
var minionCount = int.Parse(Console.ReadLine());
var truckCount = int.Parse(Console.ReadLine());

var totalToys = puzzleCount + dollCount + bearCount + minionCount + truckCount;
var totalWin = puzzle * puzzleCount +
               doll * dollCount +
               bear * bearCount +
               minion * minionCount +
               truck * truckCount;

if (totalToys >= 50)
{
    totalWin -= totalWin * 25 / 100;
}

var rent = totalWin * 10 / 100;
var profit = totalWin - rent;

Console.WriteLine(profit >= tripPrice ? $"Yes! {(profit - tripPrice):F2} lv left." : $"Not enough money! {(tripPrice - profit):F2} lv needed.");