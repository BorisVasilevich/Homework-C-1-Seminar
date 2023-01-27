//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int numdigits (int n){
int sum = 0;

while (n > 0)
{
    sum += n % 10;
    n = n/10;
    
}
return sum;
}

Console.Write("Введите число num ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма цифр в числе ровна ");
Console.WriteLine(numdigits(n));






