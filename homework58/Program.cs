//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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


int [,] GeneratMatTwo(int m, int n, int min, int max)
{
    int [,] mattwo = new int [m, n];
    Random random = new Random();

    for (int i = 0; i < mattwo.GetLength(0);i++)
        for (int j = 0; j < mattwo.GetLength(1);j++)
        mattwo [i,j] =  random.Next(min, max);
    return mattwo;
}


int [,] Myltiplication(int [,] matrix, int [,]mattwo)
{
    if (matrix.GetLength(1) != mattwo.GetLength(0))
    {
        Console.WriteLine("Умножение невозможно!!!");
        throw new Exception("Количество столбцов первой матрицы не равно количеству строк второй матрицы!");
        
    }
    var matrixThree = new int [matrix.GetLength(0), mattwo.GetLength(1)];
    for (int i =0;i < matrix.GetLength(0);i++)
    {
        for (int j = 0;j < mattwo.GetLength(1);j++)
        {
            matrixThree [i,j] = 0;
            for (int k =0;k < matrix.GetLength(1);k++)
            {
                matrixThree [i,j] += matrix [i,k] * mattwo [k,j];
            }
        }
    }
    return matrixThree;
}


int [,] matrix = GeneratMatrix(3, 2, 0, 10);
PrintMatrix2D(matrix);
Console.WriteLine();

int [,] mattwo = GeneratMatTwo(2, 3, 1, 11);
PrintMatrix2D(mattwo);
Console.WriteLine();

var matrixThree = Myltiplication(matrix, mattwo);
PrintMatrix2D(matrixThree);
Console.WriteLine();
