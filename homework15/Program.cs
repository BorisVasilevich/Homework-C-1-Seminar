//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру от 1 до 7 обозначающую день недели ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 || number > 7){
    Console.WriteLine("Введите правельное число!!!");
    return;
}

if (number == 1)
{
    Console.WriteLine("Понедельник. Будний. Нет");
}
if (number == 2)
{
    Console.WriteLine("Вторник. Будний. Нет");
}
if (number == 3)
{
    Console.WriteLine("Среда. Будний. Нет");
}
if (number == 4)
{
    Console.WriteLine("Четверг. Будний. Нет");
}
if (number == 5)
{
    Console.WriteLine("Пятница. Будний. Еще Нет, но ближе к да");
}
if (number == 6)
{
    Console.WriteLine("Ура-а-а. Суббота. Выходной. Да-а-а-а");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье. Выходной. Да, завтра на работу!");
}





