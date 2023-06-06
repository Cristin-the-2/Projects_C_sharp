// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] ReadArr(string text)
{
    Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
}

void FindCross(double[] k, double[] b, int minX, int maxX)
{
    for (double x = minX; x < maxX+1; x+=0.5)
    {
        double y1 = k[0]*x + b[0];
        double y2 = k[1]*x + b[1];
        if(y1 == y2)
        {
            Console.WriteLine($"Координата пересечения двух прямых: {x}, {y1}.");
            return;
        }
    }
    Console.WriteLine($"Прямые не пересекаются.");
}

double[] k = ReadArr("Введите числа k1 и k2 через пробел: ");
double[] b = ReadArr("Введите числа b1 и b2 через пробел: ");
FindCross(k, b, -1000, 1000);