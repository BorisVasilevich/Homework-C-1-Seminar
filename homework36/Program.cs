//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Write("Введите длинну массива ");
int t = Convert.ToInt32(Console.ReadLine());
int [] array = new int [t];


int [] raisearray(int [] array)
{
    for (int i = 0; i < array.Length;i++){
    array [i] = new Random().Next(-50, 50);
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
        if (i % 2 != 0)
        {
            count+= array[i];
        }
    }
return count;
}


Console.Write($"Сумма элементов, стоящих на нечётных позициях по индексу {HonestNum(array)}");

