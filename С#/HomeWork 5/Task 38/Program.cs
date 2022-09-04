double [] CreateRandomArray(int size, int minValue, int maxValue)
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return array;
}
void PrintArray(double [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.WriteLine("]");
}
void MaxMinusMin(double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine($"{max:f2} - {min:f2} = {max - min:f2}");
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double [] newArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(newArray);
MaxMinusMin(newArray);