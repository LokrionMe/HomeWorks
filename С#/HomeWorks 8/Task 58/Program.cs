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
int[,] ArraysMultiplication(int[,] array1, int[,] array2)
{
    int[,] newArr = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            int a = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                a = array1[i, k] * array2[k, j];
                newArr[i, j] += a;
            }
        }
    return newArr;
}
int[,] array1 = CreateRandom2dArray();
Print2dArray(array1);
int[,] array2 = CreateRandom2dArray();
Print2dArray(array2);
Print2dArray(ArraysMultiplication(array1, array2));