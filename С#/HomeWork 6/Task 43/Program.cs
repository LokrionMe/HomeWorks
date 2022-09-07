void IntersectionOfLines (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Intersection point ({x:f2};{y:f2})");
}
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
IntersectionOfLines(b1, k1, b2, k2);