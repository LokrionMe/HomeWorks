int InputNumber(string line)
{
    Console.Write(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,,] CreateRandom3dArray()
{
    int lvl = InputNumber("Ammount of levels: ");
    int m = InputNumber("Ammount of strings: ");
    int n = InputNumber("Ammount of column: ");
    int[,,] array = new int[lvl, m, n];
    return array;
}
int[,,] RandomNumberArray(int[,,] array)
{
    int minValue = InputNumber("Input minimum: ");
    int maxValue = InputNumber("Input maximum: ");
    if (maxValue < minValue)      /*на случай если человек перепутал что идет раньше -27 или -1*/
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }
    int len = maxValue - minValue + 1;
    if (len < 0) len *= (-1);
    if (len < array.Length)
    {
        Console.WriteLine($"Not enough variables - i added {array.Length - len} to {maxValue}");
        len += array.Length - len;
    }
    int[] Numarray = new int[len];
    for (int k = 0; k < Numarray.Length; k++)
    {
        Numarray[k] = minValue;
        minValue++;
    }
    int h = 0;
    for (int l = 0; l < array.GetLength(0); l++)
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = 0; j < array.GetLength(2); j++)
            {
                int randomIndex = new Random().Next(0, len - 1);
                array[l, i, j] = Numarray[randomIndex];
                int temp = Numarray[randomIndex];
                Numarray[randomIndex] = Numarray[Numarray.Length - 1 - h];
                Numarray[Numarray.Length - 1 - h] = temp;
                h++;
                len--;
            }
    return array;
}
void Print3dArray(int[,,] array)
{
    for (int l = 0; l < array.GetLength(0); l++)
    {
        Console.WriteLine($"Level {l + 1}:");
        Console.Write("[");
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
                Console.Write($"{array[l, i, j]}, ");
            if (i != array.GetLength(1) - 1) Console.Write("\b\b;\n ");
            else Console.Write("\b\b]\n");
        }
    }
}
int[,,] newArr = CreateRandom3dArray();
newArr = RandomNumberArray(newArr);
Print3dArray(newArr);