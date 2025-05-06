var n1 = int.Parse(Console.ReadLine());
var n2 = int.Parse(Console.ReadLine());
var sign = char.Parse(Console.ReadLine());

double result = 0;

switch (sign)
{
    case '+':
        result = n1 + n2;
        Console.WriteLine($"{n1} + {n2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;
    case '-':
        result = n1 - n2;
        Console.WriteLine($"{n1} - {n2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;
    case '*':
        result = n1 * n2;
        Console.WriteLine($"{n1} * {n2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;
    case '/':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = (double)n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {result:F2}");
        }
        break;
    case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            int remainder = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {remainder}");
        }
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}