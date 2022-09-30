string[] CreateArray()
{
    Console.Write("Input ammount of phrases: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input phrase: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length;i++)
    {
        if (i<array.Length - 1) Console.WriteLine($"{array[i]};");
        if (i==array.Length - 1) Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}
int checkSize(string [] array)
{
    int k = 0;
    for(int i = 0;i < array.Length; i++)
    {
        if (array[i].Length<4) k++;
    }
    return k;
}
string [] ExcludeBigPhrase(string [] array)
{
    string [] newArray = new string [checkSize(array)];
    int k = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i].Length<4)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}
string[] NewArray = CreateArray();
PrintArray(NewArray);
string[] chArray = ExcludeBigPhrase(NewArray);
PrintArray(chArray);