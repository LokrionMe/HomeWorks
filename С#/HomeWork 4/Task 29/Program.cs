int [] CreateArray(int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Input {i + 1} number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
}
Console.Write("Input quanity of array : ");
int num = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateArray(num);
PrintArray(newArr);