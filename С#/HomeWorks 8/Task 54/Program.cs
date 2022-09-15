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
int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int len = array.GetLength(1);
        while (len != 1)
        {
            for (int j = 0; j < len - 1; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            len--;
        }
    }
    return array;
}
int[,] newArr = CreateRandom2dArray();
Print2dArray(newArr);
Print2dArray(Sort(newArr));