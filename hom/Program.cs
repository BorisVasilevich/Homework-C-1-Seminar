Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

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

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

 PrintMatrix2D(sqareMatrix);
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