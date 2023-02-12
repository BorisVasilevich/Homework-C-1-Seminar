//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07



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

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 10;
int i = 0;
int j = 0;

while (temp <= (sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))+10)
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintMatrix2D(sqareMatrix);
Console.WriteLine();