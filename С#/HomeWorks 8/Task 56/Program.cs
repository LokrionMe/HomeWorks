int InputNumber(string line)
{
    Console.Write(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] CreateRandom2dArray()
{
    int m = InputNumber("Ammount of strings: ");
    int n = InputNumber("Ammount of column: ");
    int minValue = InputNumber("Input minimum: ");
    int maxValue = InputNumber("Input maximum: ");
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
void MinimalRow(int[,] array)
{
    int minimum = 0;
    int minRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        minimum += array[0, j];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (sum < minimum)
        {
            minimum = sum;
            minRow = i;
        }
    }
    Console.WriteLine($"Minimal row is {minRow + 1} and sum = {minimum}");
}
int[,] newArr = CreateRandom2dArray();
Print2dArray(newArr);
MinimalRow(newArr);