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
