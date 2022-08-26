void Sqr(int num)
{
    int i = 1;
    while (i<=num) 
    {
        Console.Write($"{i*i*i} ");
        i ++;
    }
}
Console.Write("Input integer number:");
int number = Convert.ToInt32(Console.ReadLine());
Sqr(number);