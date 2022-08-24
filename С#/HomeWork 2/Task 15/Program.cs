bool CheckDay(int num)
{
    if ((num>5)&(num<8)) return true;
    return false;
}
Console.Write("Input positive integer number:");
int num = Convert.ToInt32(Console.ReadLine());
bool result = CheckDay(num);
if (result == true) Console.WriteLine("Weekend");
else Console.WriteLine("No Weekend");