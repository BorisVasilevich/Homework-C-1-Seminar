//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.Write("Введите длинну массива ");
int t = Convert.ToInt32(Console.ReadLine());
int [] array = new int [t];

Console.Write("Введите минимальгое значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона  ");
int max = Convert.ToInt32(Console.ReadLine());


int [] raisearray(int [] array)
{
    for (int i = 0; i < array.Length;i++){
    array [i] = new Random().Next(min, max);
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
    return;
}

raisearray(array);
PrintArray(array);




