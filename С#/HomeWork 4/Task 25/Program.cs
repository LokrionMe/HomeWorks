int sqr (int num, int step)
{
    int pr = 1;
    for (int i = 1; i <= step; i++)
    {
        pr *= num;
    }
    return pr;
}
Console.Write("Input integer number");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree");
int level = Convert.ToInt32(Console.ReadLine());
int number = sqr(num, level);
Console.WriteLine($"{num} in {level} = {number}");