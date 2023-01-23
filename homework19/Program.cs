//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
//int number = System.Convert.ToInt32(Console.ReadLine());

if (!int.TryParse(Console.ReadLine(), out int number)|| (number <= 9999 || number >= 100000))
{
    Console.WriteLine("Введено не правильное число.");
    return;
}
int drink = 10000;
int digit = 10;

int Palindrom(int number)
{
if ((number / drink == number % digit) && (((number * 10/drink ) %10) == ((number % (digit * 10)) / 10)))
return 1;

else
return 2;
}
var result = Palindrom(number);
if (result == 1)
Console.WriteLine("Число является полиндромом!");
else
Console.WriteLine("Число не является полиндромом.");



