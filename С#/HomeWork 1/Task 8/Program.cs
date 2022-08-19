Console.Write("Input positive integer number:");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if (current % 2 == 0)
    {
    Console.Write($"{current}, ");
    }
    current ++;
}