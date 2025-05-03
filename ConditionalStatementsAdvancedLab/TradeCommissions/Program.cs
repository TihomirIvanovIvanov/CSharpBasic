var city = Console.ReadLine();
var salesQuantity = decimal.Parse(Console.ReadLine());

if (city == "Sofia")
{
    if (salesQuantity >= 0 && salesQuantity <= 500)
    {
        Console.WriteLine($"{(salesQuantity * 5 / 100):F2}");
    }
    else if (salesQuantity > 500 && salesQuantity <= 1000)
    {
        Console.WriteLine($"{(salesQuantity * 7 / 100):F2}");
    }
    else if (salesQuantity > 1000 && salesQuantity <= 10000)
    {
        Console.WriteLine($"{(salesQuantity * 8 / 100):F2}");
    }
    else
    {
        Console.WriteLine($"{(salesQuantity * 12 / 100):F2}");
    }
}
else if (city == "Varna")
{
    if (salesQuantity >= 0 && salesQuantity <= 500)
    {
        Console.WriteLine($"{(salesQuantity * 4.5m / 100):F2}");
    }
    else if (salesQuantity > 500 && salesQuantity <= 1000)
    {
        Console.WriteLine($"{(salesQuantity * 7.5m / 100):F2}");
    }
    else if (salesQuantity > 1000 && salesQuantity <= 10000)
    {
        Console.WriteLine($"{(salesQuantity * 10 / 100):F2}");
    }
    else
    {
        Console.WriteLine($"{(salesQuantity * 13 / 100):F2}");
    }
}
else if (city == "Plovdiv")
{
    if (salesQuantity >= 0 && salesQuantity <= 500)
    {
        Console.WriteLine($"{(salesQuantity * 5.5m / 100):F2}");
    }
    else if (salesQuantity > 500 && salesQuantity <= 1000)
    {
        Console.WriteLine($"{(salesQuantity * 8 / 100):F2}");
    }
    else if (salesQuantity > 1000 && salesQuantity <= 10000)
    {
        Console.WriteLine($"{(salesQuantity * 12 / 100):F2}");
    }
    else if (salesQuantity > 10000)
    {
        Console.WriteLine($"{(salesQuantity * 14.5m / 100):F2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("error");
}