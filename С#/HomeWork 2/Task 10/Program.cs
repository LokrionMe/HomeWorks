void GetSecondNumber(int num)
{
    Console.WriteLine(num % 100 / 10);
}
Console.Write("Input three - digit number:");
int num = Convert.ToInt32(Console.ReadLine());
GetSecondNumber(num);