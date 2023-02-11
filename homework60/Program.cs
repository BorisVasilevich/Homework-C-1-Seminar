//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int [,,] GeneratMatrix3d(int m, int n, int l, int min, int max)
{
    int [,,] matrix = new int [m, n, l];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            for (int k = 0;k < matrix.GetLength(2);k++)
            {
            int element = random.Next(min, max);
            if (FindElement(matrix, element)) continue;
            matrix [i,j,k] = element;
            }
        }
    }
return matrix;
}

void PrintMatrix3D(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0);i++){
        for (int j = 0; j < matrix.GetLength(1);j++){
            for (int k =0;k < matrix.GetLength(2);k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }  
    } 
}

 bool FindElement(int[,,] matrix, int el)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

int [,,] matrix = GeneratMatrix3d(2, 2, 2, 10, 100);
PrintMatrix3D(matrix);
Console.WriteLine();

