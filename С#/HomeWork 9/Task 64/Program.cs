int InputNumber(string line)
{
    Console.Write(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void ShowNums(int m, int n)
{
    if (n > m)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if (m > n) ShowNums(m - 1,n);
    Console.Write(m + " ");
}
int a = InputNumber("Input minimum: ");
int b = InputNumber("Input maximum: ");
ShowNums(b, a);