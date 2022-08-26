double LenSegment(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double len = (x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1);
    double result = Math.Sqrt(len);
    return result;
}
Console.Write("Input x1:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2:");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1:");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2:");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Len from A({xA},{yA},{zA}) to B({xB},{yB},{zB}) = {LenSegment(xA, yA, xB, yB, zA, zB)} ");