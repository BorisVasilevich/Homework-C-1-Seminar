//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет


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

int [,] matrix = GeneratMatrix(3, 4, -10, 10);

PrintMatrix2D(matrix);

Console.WriteLine("Введите намер строки в матрице: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца в матрице: ");
int m = Convert.ToInt32(Console.ReadLine());



for (int i = 0; i < matrix.GetLength(0);i++)
{
    for (int j = 0; j < matrix.GetLength(1);j++)
    {
        if (i == n && j == m)
        {
        object result = matrix.GetValue (n, m)!;
        Console.WriteLine(result);
        }
    
    }

}

 if (matrix.GetLength(0) < n || matrix.GetLength(1) < m)
    {
      Console.WriteLine("Такого числа в массиве нет");  
    }


