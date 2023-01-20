Console.WriteLine("Показ диапазона четных чисел от 1 до числа!");

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count < number)
{
    Console.Write(count+" ");
    count+=2;
}



