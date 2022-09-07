/*хотел посмотреть насколько большую и глубокую выборку можно сделать: при х от -100 до 100
и при шаге в 0,1 консоль просто завершает свою работу не отобразив ничего.
хотя всё что касается шага 0,5 всё работает стабильно и корректно*/ 

void IntersectionOfLines (double b1, double k1, double b2, double k2, double min, double max, double step)
{
    double x = min;
    while (x < max)
    {
        double y1 = k1 * x + b1;
        double y2 = k2 * x + b2;
        if (y1 == y2) 
        {
            Console.WriteLine($"Itersection point of lines ({x};{y1}) on range ({min};{max})");
            break;
        } 
        x += step ;
    }        
    if (x == max) Console.WriteLine($"Intersection point is empty on range ({min};{max})");   
}
Console.Write("Input minimum of range: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maximum of range(except last number): ");
double max = Convert.ToDouble(Console.ReadLine());
Console.Write("Input step: ");
double step = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
IntersectionOfLines(b1, k1, b2, k2, min, max, step);