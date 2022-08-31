int SumOfNumbers(int num)
{
    int sum = 0;
    while (num != 0)
        {
        sum = sum + num % 10;
        num /= 10;
        }
    return sum;
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumOfNumbers(num);
Console.WriteLine($"Amount numbers of {num} = {sum}");