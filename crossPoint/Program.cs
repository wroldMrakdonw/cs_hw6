// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    System.Console.Write($"{message}: ");
    double n = Convert.ToInt32(Console.ReadLine());
    return n;
}

bool IsCrossPoint(double k1, double k2)
{
    return k1 != k2;
}

// (double - коэффицент при x, double - свободный член) firstLine
(double, double) CrossPoint((double, double) firstLine, (double, double) secondLine)
{
    double k1 = firstLine.Item1, b1 = firstLine.Item2;
    double k2 = secondLine.Item1, b2 = secondLine.Item2;
    double k = k1 - k2, b = b1 - b2; // k1x + b1 = k2x + b2 <=> (k1-k2)x + (b1-b2) = 0
    double x = b * -1 / k; // kx + b = 0 <=> x = -b / k
    double y = k1 * x + b1;
    return (x, y);
}

System.Console.WriteLine("Задайте 2 прямые уравнениями y = kx + b");
double k1 = Prompt("Введите 1-й коэффицент при x (k1)");
double b1 = Prompt("Введите 1-й свободный член (b1)");
double k2 = Prompt("Введите 2-й коэффицент при x (k2)");
double b2 = Prompt("Введите 2-й свободный член (b2)");
if (IsCrossPoint(k1, k2))
{
    var (x, y) = CrossPoint((k1, b1), (k2, b2));
    System.Console.WriteLine($"Прямые пересекаются в точке {x}, {y}.");
}
else System.Console.WriteLine("Прямые параллельны.");