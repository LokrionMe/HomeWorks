void ShowThirdNumber(int num)
{
    if (num>99) Console.WriteLine(num%1000/100);
    else Console.WriteLine("Third number is empty");
}
Console.Write("Input positive integer number:");
int num = Convert.ToInt32(Console.ReadLine());
ShowThirdNumber(num);