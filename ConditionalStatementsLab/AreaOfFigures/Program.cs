var figure = Console.ReadLine();
switch (figure)
{
    case "square":
        var side = double.Parse(Console.ReadLine());
        Console.WriteLine($"{side * side:F3}");
        break;
    case "rectangle":
        var w = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        Console.WriteLine($"{w * h:F3}");
        break;
    case "circle":
        var radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"{Math.PI * radius * radius:F3}");
        break;
    default:
        var b = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Console.WriteLine($"{(b * height) / 2:F3}");
        break;
}