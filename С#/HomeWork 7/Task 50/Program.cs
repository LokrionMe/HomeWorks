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
void ShowNumber(int[,] array)
{
    Console.Write($"Input row number of array from 1 to {array.GetLength(0)} : ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input column number of array from 1 to {array.GetLength(1)} : ");
    int col = Convert.ToInt32(Console.ReadLine());
    if (row <= array.GetLength(0) & col <= array.GetLength(1))
    {
        Console.WriteLine($"{array[row - 1, col - 1]}");
    }
    else Console.WriteLine("Wrong number of row or column");
}
int[,] newArr = CreateRandom2dArray();
Print2dArray(newArr);
ShowNumber(newArr);