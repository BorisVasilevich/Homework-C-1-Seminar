//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


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


void BackStringMatrix(int [,] matrix)
{
for (int i = 0;i < matrix.GetLength(0);i++)
{
    for (int j = 0;j < matrix.GetLength(1);j++)
    {
        for (int k = 0; k < matrix.GetLength(1)-1;k++)
        {        
        if (matrix[i,k] < matrix [i,k+1])
        {
            int temp = matrix [i,k];
            matrix[i,k] = matrix [i,k+1];
            matrix [i,k+1] = temp;
        }
        }
    }

}
}

int [,] matrix = GeneratMatrix(3, 4, 0, 10);
PrintMatrix2D(matrix);
BackStringMatrix(matrix);
Console.WriteLine();
PrintMatrix2D(matrix);
