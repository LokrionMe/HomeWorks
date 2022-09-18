int InputNumber(string line)
{
    Console.Write(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Aker(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return Aker(m - 1, 1);
    if ((m > 0) && (n > 0)) return Aker(m - 1, Aker(m, n - 1));
    return Aker(m, n);
}
int m = InputNumber("Input m: ");
int n = InputNumber("Input n: ");
Console.WriteLine(Aker(m, n));