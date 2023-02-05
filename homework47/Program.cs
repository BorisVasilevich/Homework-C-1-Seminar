//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


double [,] GeneratMatrix(int m, int n, int min, int max)
{
    double [,] matrix = new double [m, n];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0);i++)
        for (int j = 0; j < matrix.GetLength(1);j++)
        matrix [i,j] = Convert.ToDouble(new Random().Next(min, max))/10;
    return matrix;
}

void PrintMatrix2D(double [,] matrix)
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

double [,] matrix = GeneratMatrix(3, 4, -10, 100);

PrintMatrix2D(matrix);


