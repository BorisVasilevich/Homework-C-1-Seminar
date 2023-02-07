//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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


    double result = 0;
    
    for (int j = 0;j < matrix.GetLength(1);j++)
    {
        for (int i = 0; i < matrix.GetLength(0);i++)
        {
            result += matrix [i,j]; 
        }
        Console.Write($" {Math.Round(result / matrix.GetLength(0), 1)}");
        result = 0;
    }




