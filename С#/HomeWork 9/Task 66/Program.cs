int InputNumber(string line)
{
    Console.Write(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SumOfDigits(int m, int n)
{
    if (n > m)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if (m > n) return SumOfDigits(m - 1,n) + m;
    return m;
}
int a = InputNumber("Input minimum: ");
int b = InputNumber("Input maximum: ");
Console.WriteLine(SumOfDigits(b, a));