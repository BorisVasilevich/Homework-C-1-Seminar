//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



Console.Write("Введите длинну массива ");
int t = Convert.ToInt32(Console.ReadLine());
int [] array = new int [t];


int [] raisearray(int [] array)
{
    for (int i = 0; i < array.Length;i++){
    array [i] = new Random().Next(100, 999);
    }
    return array;
}

void PrintArray(int [] array)
{
    int i =0;
    Console.Write($"Итоговый массив: [  {array[i]}");
    for (i = 1;i < array.Length;i++)
    {
Console.Write($", {array[i]}");
    }
    Console.Write(" ] ");
    Console.WriteLine();
    return;
}

raisearray(array);
PrintArray(array);


int HonestNum(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
return count;
}

Console.Write($"Количество чётных чисел в массиве {HonestNum(array)}");

