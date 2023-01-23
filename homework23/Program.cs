//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");

if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0) {
Console.WriteLine("Введено не целое или отрицательное число");
return;
}

int count = 1;

while (count <= number){
int result = count * count * count;
Console.Write($"  {result}");
count++;
}




int xa, ya, xb, yb;
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
double Distance(double xa, double ya, double xb, double yb)
{
return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
}

double res = Distance(xa, ya, xb, yb);
Console.WriteLine($"Расстоняние между двум точками - {res}");
