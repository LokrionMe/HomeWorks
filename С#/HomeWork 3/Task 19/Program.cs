bool CheckPolyndrom(int num)
{
    int dev = 0;
    int num3 = 0;
    int num2 = num;
    if (num / 10 == 0) return false;
    else
    {
        while (num2 != 0)
        {
        dev = num2 % 10;
        num2 = num2 / 10;
        num3 = num3 *10 + dev;
        }
    }
    if (num == num3) return true;
    else 
    return false;
}
Console.Write("Input first integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
if (CheckPolyndrom(num1) == true) Console.WriteLine($"{num1} - polyndrom");
else Console.WriteLine($"{num1} - NOT polyndrom");