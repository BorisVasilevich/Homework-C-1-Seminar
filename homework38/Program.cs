//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Введите длинну массива ");
int t = Convert.ToInt32(Console.ReadLine());
double [] array = new double [t];


double [] raisearray(double [] array)
{
    for (int i = 0; i < array.Length;i++){
    array [i] = new Random().Next(1, 3);
    }
    return array;
}

void PrintArray(double [] array)
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

double MinMax (double [] array)
{
    double max = array [0];
    double min = array [1];
    if (array [0] < array [1])
    {
        max = array [1];
        min = array [0];
    }
    for (int i = 2; i < array.Length;i++)
    {
if (max < array[i]){
max = array[i];
}
if (min > array[i])
{
min = array[i];
}
  
    }
    double result = max - min;
return result;
}
Console.WriteLine($"Разница между максимальным и минимальным значением массива {MinMax(array)}");








