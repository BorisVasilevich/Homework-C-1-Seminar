//Григорий Вахмистров:  17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int CalculateQuarter(int x, int y) {
if (x > 0 && y > 0)
return 1;
else if (x < 0 && y > 0)
return 2;
else if (x < 0 && y < 0)
return 3;
else if (x > 0 && y < 0)
return 4;
else
return -1;
}
Console.WriteLine("Программа для вычисления номера четверти точки на плоскости");

Console.WriteLine("Введите координату X:");
if (!int.TryParse(Console.ReadLine(), out var x))
Console.WriteLine("Введено не целое число");

if (x == 0) {
Console.WriteLine("Точка не должна лежать на оси");
return;
}

Console.WriteLine("Введите координату Y:");
if (!int.TryParse(Console.ReadLine(), out var y))
Console.WriteLine("Введено не целое число");

if (y == 0) {
Console.WriteLine("Точка не должна лежать на оси");
return;
}

var result = CalculateQuarter(x, y);

if (result != -1) {
Console.WriteLine($"Точка ({x}, {y}) находится в четверти {result}");
Console.WriteLine("Точка (" + x + ", " + y + ") находится в четверти " + result);
}
else
Console.WriteLine("Ошибка при вычислении, входные данные не верны");

//Another task!!!


Console.WriteLine("Введите диапазон от 1 до 4");

int number;
while(!Int32.TryParse(Console.ReadLine(), out number))
{
Console.Write("Вы ввели не число! Повторите попытку: ");
}

Quarter(number);


void Quarter(int number)
{
if (number == 1)
{
Console.WriteLine("Первая четверть. X > 0, Y > 0");
}
else if (number == 2)
{
Console.WriteLine("Вторая четверть. X < 0, Y > 0");
}
else if (number == 3)
{
Console.WriteLine("Третья четверть. X < 0, Y < 0");
}
else if (number == 4)
{
Console.WriteLine("Четвертая четверть. X > 0, Y < 0");
}
else
Console.WriteLine("Введен неверный диапазон!");
}

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//AB = √((xb - xa)2 + (yb - ya)2)

Console.WriteLine("Введите координату X для точки А:");
if (!int.TryParse(Console.ReadLine(), out var x1))
Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату Y для точки A:");
if (!int.TryParse(Console.ReadLine(), out var y1))
Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату X для точки B:");
if (!int.TryParse(Console.ReadLine(), out var x2))
Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату Y для точки B:");
if (!int.TryParse(Console.ReadLine(), out var y2))
Console.WriteLine("Введено не целое число");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
distance = Math.Round(distance, 3);
Console.WriteLine($"Расстояние между точками А и B: {distance}");

// ТОже самое, решение другого студента.

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

//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число: ");

if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0) {
Console.WriteLine("Введено не целое или отрицательное число");
return;
}

int count = 1;
Console.Write(count * count);
count++;
while(count <= N) {
Console.Write(", " + count * count);

count++;
}

int number = 12521;
int drink = 10000;
int digit = 10;


int a = number / drink;
Console.WriteLine("First: " + a);

int b = number % digit;
Console.WriteLine("Poslednay: " + b);

//if (number / drink == number % digit)  

int c = ((number * 10/drink ) %10);
Console.WriteLine("Second: " + c);

int d = ((number % (digit * 10)) / 10);
Console.WriteLine("Forth: " + d);




//else if (((number /drink * 10) %10) == ((number % digit * 10) / 10))






string text = (" - Правительство РФ продлевает отсрочку по уплате страховых  культуры и туризма, уже воспользовавшихся отсрочкой ранее.");

string Replace (string text, char old value, char new value);
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0, i < length, i++)
    {
    if (text [i] == old value, result = result + $"{new value}");
    else result + $"{str[i]}";
    }
    return result;
}
string new text = Replace (text,"т", "Т");
Console.WriteLine(new text);



Evgenii Kolokoltsev  кому  Все 20:16
int[] array = new int[8];
void FillArray(int[] array)
    {
    Console.WriteLine($"Формируем массив из {array.Length} элементов");
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0, 2);
    }
    return;
    }

void PrintArray(int[] array)
    {
    int i = 0;
    Console.Write($"Итоговый массив: [ {array[i]}");
    for (i = 1; i < array.Length; i++)
    {
    Console.Write($", {array[i]}");
    }
    Console.Write(" ]");
    return;
    }

FillArray(array);
PrintArray(array);



