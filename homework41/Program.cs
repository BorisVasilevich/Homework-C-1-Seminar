//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4


Console.WriteLine("Какое количество цифр собираетесь вводить: ");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int [m];

int [] EnterNumbers(int [] array)
{
     
for (int i = 0; i < m;i++)
{
int f = Convert.ToInt32(Console.ReadLine()); 
array [i] = f; 
}
return array;
}

void PrintArray(int [] array)
{
    int i =0;
    Console.Write($"Итоговый массив: [ {array[i]}");
    for (i = 1;i < array.Length;i++)
    {
Console.Write($", {array[i]}");
    }
    Console.Write(" ] ");
    Console.WriteLine();
    return;
}




int  whatNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

EnterNumbers(array);
PrintArray(array);

int count = whatNumbers(array);
Console.WriteLine($" {count} раз(а) больше 0 ввёл пользователь.");

