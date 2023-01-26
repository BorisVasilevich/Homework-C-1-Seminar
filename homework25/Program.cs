//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Число  num возводим в степень step!");

int numberdigit (int num, int step)
{
    num = Math.Abs(num);
    step = Math.Abs(step);
    int count = 1;
    int result = 1;
    while (count <= step)
    {
        result = result * num;
        count ++;
    }
return result;
}

Console.Write("Введите число num ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень step ");
int step = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numberdigit(num, step));







