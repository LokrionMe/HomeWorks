Console.Write("Input first integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number:");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
    if (num3 > max)
    {
        max = num3;
        Console.WriteLine($"max = {num3}");
    }
    else
    {
        Console.WriteLine($"max = {num2}");
    }
}
else
{
    if (num3 > max)
    {
        max = num3;
        Console.WriteLine($"max = {num3}");
    }
    else
    {
        Console.WriteLine($"max = {num1}");
    }
}