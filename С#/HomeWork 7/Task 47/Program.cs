double[,] CreateRandom2dArray(int m, int n, int minimum, int maximum)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minimum, maximum) + new Random().NextDouble();
    return array;
}
void Print2dArray(double[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:f2}, ");
        if (i != array.GetLength(0) - 1) Console.Write("\b\b;\n ");
        else Console.Write("\b\b]");
    }
}
Console.Write("Ammount of strings: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ammount of column: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum: ");
int minValue = Convert.ToInt32(Console.ReadLine());
double[,] newArr = CreateRandom2dArray(m, n, minValue, maxValue);
Print2dArray(newArr);