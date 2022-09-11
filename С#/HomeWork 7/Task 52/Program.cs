int[,] CreateRandom2dArray()
{
    Console.Write("Ammount of strings: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ammount of column: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimum: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Print2dArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}, ");
        if (i != array.GetLength(0) - 1) Console.Write("\b\b;\n ");
        else Console.Write("\b\b]\n");
    }
}
double[] Average(int[,] array)
{
    double[] avArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double k = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            k = k + array[j, i];
        avArray[i] = k / array.GetLength(0);
    }
    return avArray;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]:f2}; ");
    Console.Write("\b\b]");
}
int[,] newArr = CreateRandom2dArray();
Print2dArray(newArr);
double[] averArrow = Average(newArr);
PrintArray(averArrow);