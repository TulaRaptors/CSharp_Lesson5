// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();


double k1 = 2;
double b1 = 7;
double k2 = -4;
double b2 = 5;

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    double x = (b2-b1)/(k1-k2);
    double y = x * k1 + b1;
    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} пересекаются в точке: ({Math.Round(x,2)}; {Math.Round(y,2)})");
}