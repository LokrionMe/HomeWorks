Console.Write("Input first integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
else
{
    Console.WriteLine($"max = {num2}, min = {num1}");
}