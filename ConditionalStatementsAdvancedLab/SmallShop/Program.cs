const decimal cs = 0.5m;
const decimal ws = 0.8m;
const decimal bs = 1.2m;
const decimal ss = 1.45m;
const decimal ps = 1.6m;

const decimal cp = 0.4m;
const decimal wp = 0.7m;
const decimal bp = 1.15m;
const decimal sp = 1.3m;
const decimal pp = 1.5m;

const decimal cv = 0.45m;
const decimal wv = 0.7m;
const decimal bv = 1.1m;
const decimal sv = 1.35m;
const decimal pv = 1.55m;

var product = Console.ReadLine();
var city = Console.ReadLine();
var quantity = decimal.Parse(Console.ReadLine());

if (city == "Sofia")
{
    Console.WriteLine(product == "coffee" ? quantity * cs :
                     (product == "water" ? quantity * ws :
                      product == "beer" ? quantity * bs :
                      product == "sweets" ? quantity * ss :
                      quantity * ps));
}
else if (city == "Plovdiv")
{
    Console.WriteLine(product == "coffee" ? quantity * cp :
                     (product == "water" ? quantity * wp :
                      product == "beer" ? quantity * bp :
                      product == "sweets" ? quantity * sp :
                      quantity * pp));
}
else
{
    Console.WriteLine(product == "coffee" ? quantity * cv :
                     (product == "water" ? quantity * wv :
                      product == "beer" ? quantity * bv :
                      product == "sweets" ? quantity * sv :
                      quantity * pv));
}