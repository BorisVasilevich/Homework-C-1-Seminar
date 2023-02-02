//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа, которая находит точку пересечения двух прямых,");
Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");


Console.WriteLine("Введите значение b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double PointX(double b1, double b2, double k1, double k2)
{
double x = (b2 - b1) / (k1 - k2);
 return x;
}   

double PointY(double b1, double b2, double k1, double k2)
{
double y = k2 * ((b2 - b1) / (k1 - k2)) + b2;    
    return y;
}

double t = PointX(b1, b2, k1, k2);
double p = PointY(b1, b2, k1, k2);
Console.WriteLine($"Точка пересечения двух прямых имеет координаты X: {t}; Y: {p}");


//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)