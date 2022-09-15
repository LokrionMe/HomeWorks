int InputNumber(string line)
{
    Console.Write(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] CreateRandom2dArray()
{
    int m = InputNumber("Ammount of strings and columns: ");
    int[,] array = new int[m, m];
    int minRow = 0;
    int minCol = -1;
    int maxCol = array.GetLength(1);
    int maxRow = array.GetLength(0);
    int i = 0;
    int j = 0;
    int k =1;
    while (k < (array.GetLength(0)*array.GetLength(1)+1))
    {
        if (i == minRow)
        {
            while (j<maxCol)
            {
                array[i,j] = k;
                j++;
                k++; 
            }
            maxCol--;
            j--;
            i++;
        }
        if (j == maxCol)
        {
            while (i<maxRow)
            {
                array[i,j] = k;
                i++;
                k++;
            }
            i--;
            maxRow--;
            j--;
        }
        if (i == maxRow)
        {
            while( j>minCol)
            {
                array[i,j] =k;
                k++;
                j--;
            }
            minCol++;
            j++;
            i--;
        }
        if (j == minCol)
        {
            while (i>minRow)
            {
                array[i,j] = k;
                i--;
                k++;
            }
            i++;
            minRow++;
            j++;
        }
    }
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
int[,] array1 = CreateRandom2dArray();
Print2dArray(array1);