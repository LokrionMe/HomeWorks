﻿int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
void CheckMod(int [] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) current++;
    }
    Console.WriteLine($"Amount of even numbers = {current}");
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] newArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(newArray);
CheckMod(newArray);