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

