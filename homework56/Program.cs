//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int [,] GeneratMatrix(int m, int n, int min, int max)
{
    int [,] matrix = new int [m, n];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0);i++)
        for (int j = 0; j < matrix.GetLength(1);j++)
        matrix [i,j] =  random.Next(min, max);
    return matrix;
}

void PrintMatrix2D(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0);i++){
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.Write("  ");
        Console.WriteLine();
    }    
}

int [,] matrix = GeneratMatrix(3, 4, 0, 10);
PrintMatrix2D(matrix);
Console.WriteLine();

    int sum = 0; 
    int  sumline = int.MaxValue;
    int index = 0;
    for (int i = 0;i < matrix.GetLength(0);i++)
    {
    
        for (int j =0; j < matrix.GetLength(1);j++)
        {
            sum += matrix[i,j]; 
        }
     Console.Write($"{sum} ");
    if (sumline > sum)
    {
        sumline = sum;
        index = i;
    }
    sum = 0;
    }
    
    Console.Write($"Номер строки с наименьшей суммой элементов: {index+1} строка ");
    
    





