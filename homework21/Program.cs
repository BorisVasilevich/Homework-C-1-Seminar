//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int xa, ya, za, xb, yb, zb;
Console.WriteLine("Введите координату Х точки А: ");
while (!int.TryParse(Console.ReadLine(), out xa))
{
Console.Write("Введен неверный параметр");
}
Console.WriteLine("Введите координату Y точки А: ");
while (!int.TryParse(Console.ReadLine(), out ya))
{
Console.Write("Введен неверный параметр");
}
Console.WriteLine("Введите координату Z точки А: ");
while (!int.TryParse(Console.ReadLine(), out za))
{
Console.Write("Введен неверный параметр");
}



Console.WriteLine("Введите координату Х точки B: ");
while (!int.TryParse(Console.ReadLine(), out xb))
{
Console.Write("Введен неверный параметр");
}
Console.WriteLine("Введите координату Х точки B: ");
while (!int.TryParse(Console.ReadLine(), out yb))
{
Console.Write("Введен неверный параметр");
}
Console.WriteLine("Введите координату Z точки B: ");
while (!int.TryParse(Console.ReadLine(), out zb))
{
Console.Write("Введен неверный параметр");
}

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}

double res = Distance(xa, ya, za, xb, yb, zb);
res = Math.Round(res, 2);
Console.WriteLine($"Расстоняние между двум точками - {res}");







