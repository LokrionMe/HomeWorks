int [] CreateArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
void AmmountOfPositiveNumbers (int [] array)
{
    int k = 0;
    for (int i = 0;i < array.Length; i++)
    {
        if (array[i] > 0) k++;
    }
    Console.WriteLine($"Ammount of numbers > 0 = {k}");
} 
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateArray(size);
PrintArray(newArr);
AmmountOfPositiveNumbers(newArr);