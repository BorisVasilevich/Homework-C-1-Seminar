Console.WriteLine("Какое число больше");
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if (max<numberB)
{
max = numberB;
min = numberA;
}
Console.WriteLine("Число больше "+max);
Console.WriteLine("Число меньше "+min);


