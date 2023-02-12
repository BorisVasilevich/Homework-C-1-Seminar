


double[] numbers = str.Split(' ', ',', '.', ':', ';').Select(double.Parse).ToArray();
//вот так
double[] numbers = str.Split(' ', ',', '.', ':', ';').Select(double.Parse).ToArray();
 


string[] numbers = input.Split(' ')

double[] numbers = str.Split(' ', ',', '.', ':', ';').Select(double.Parse).ToArray();


Console.WriteLine("Введите массив целых чисел через пробел:");
string input = Console.ReadLine()!;
string[] numberStrings = input.Split(" ");
int[] numbers = new int[numberStrings.Length];

for (int i = 0; i < numbers.Length; i++)
    numbers[i] = int.Parse(numberStrings[i]);

PrintArray(numbers);

string[] numbers = input.Split(' ');
    foreach (string number in numbers)
    {
        if (double.TryParse(number, out double value))
        {
            ...
        }
    }



int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(min, max + 1);

    return array;
}

void PrintArray2D(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + ", ");
        Console.WriteLine();
    }
}

var array = GenerateArray(4, 3, 0, 9);
PrintArray2D(array);



int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] matrix = CreateMatrix(3, 4);

PrintMatrix(matrix);



void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            if (j == arrayPrint.GetLength(1) - 1)
                Console.WriteLine($"{arrayPrint[i,j]}]");
            else
                Console.Write($"{arrayPrint[i,j]}, ");
        }
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array2D = new int[m, n];
    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i,j] = i + j;
        }
    }
    return array2D;
}



Console.Write("Введите высоту массива = ");
int.TryParse(Console.ReadLine(), out int m);
while (m <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод высоты массива:");
    int.TryParse(Console.ReadLine(), out m);
}

Console.Write("Введите ширину массива = ");
int.TryParse(Console.ReadLine(), out int n);
while (n <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод ширины массива:");
    int.TryParse(Console.ReadLine(), out n);
}

PrintArray(Create2DArray(m, n));

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
// выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12
//функция логики задачи прочетные число матрицы в квадрате

//I = j matrix * matrix
//как то так вроде
//елси I = j*
//Владислав Шутиков  кому  Все 20:10
//обалдеть
//lvl100
//Oleg Prokopenko  кому  Все 20:11
int[,] NewMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix;
}


int[,] NewMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix;
}


int sum = MatrixSumElements(matrix2);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");



//Григорий Вахмистров  кому  Все 20:15
//https://sharplab.io/#v2:EYLgtghglgdgNAExAagD4AEBMBGAsAKHQAYACdbAOgBEAnCAd1gHMKAVAUwA8AXAbgILoAzGUwkAwiQDeBEnLLZSAOQhh20kk3Z8SAZ228SAX1nzTc8qQBiUdgBsE/fEaA==



Приостановить
Текущее время 2:08:30
/
Продолжительность 2:17:57
Скорость воспроизведения
×1
Неполноэкранный режим
Запись чата

Наталья: Добрый вечер.
Крылов Андрей: Привет
Bricksss: добрый вечер!
Крылов Андрей: +
Наталья: +
Василий Горулев: +
Алексей Поникаровский: +
Bricksss: +
Крылов Андрей: все норм
Крылов Андрей: людей мало, давайте постараемся всё успеть сегодня
Григорий Вахмистров: Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Крылов Андрей: вроде всё четко
ActaviuS: ++
Te3Ka - Илья Новичихин: Есть
Крылов Андрей: а какую матрицу нельзя транспонировать?
Крылов Андрей: вроже все можно
Zhoomart Chyrmash uulu: можно код?
Te3Ka - Илья Новичихин: /*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

void PrintArray(int[,] arrayPrint)
{
for (int i = 0; i < arrayPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayPrint.GetLength(1); j++)
{
Console.Write($"{arrayPrint[i, j]}, ");
}
Console.WriteLine();
}
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
int[,] array2D = new int[m, n];
Random random = new Random();
for (int i = 0; i < array2D.GetLength(0); i++)
{
for (int j = 0; j < array2D.GetLength(1); j++)
{
array2D[i, j] = random.Next(min, max + 1);
}
}
return array2D;
}

int[,] SwapArray2d(int[,] oldArray)
{
int[,] newArray = new int[oldArray.GetLength(1), oldArray.GetLength(0)];
for (int i = 0; i < oldArray.GetLength(1); i++)
{
for (int j = 0; j < oldArray.GetLength(0); j++)
{
Te3Ka - Илья Новичихин: /*
Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.

*/

void PrintArray(int[,] arrayPrint)
{
for (int i = 0; i < arrayPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayPrint.GetLength(1); j++)
{
Console.Write($"{arrayPrint[i,j]}, ");
}
Console.WriteLine();
}
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
int[,] array2D = new int[m, n];
Random random = new Random();
for (int i = 0; i < array2D.GetLength(0); i++)
{
for (int j = 0; j < array2D.GetLength(1); j++)
{
array2D[i,j] = random.Next(min, max + 1);
}
}
return array2D;
}

int[,] SwapStringArray2d(int[,] oldArray)
{
int temp = 0;
for (int i = 0; i < oldArray.GetLength(1); i++)
{
temp = oldArray[oldArray.GetLength(0) - 1, i];
oldArray[oldArray.GetLength(0) - 1, i] = oldArray[0, i];
oldArray[0, i] = temp;
}
return oldArray;
}
ActaviuS: Решения аналогичное
Григорий Вахмистров: Решение в группах задач:
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Василий Горулев: 1 зал выполнили
Василий Горулев: 1 зал выполнили
Крылов Андрей: Илья, а мы 2 зал? Тоже выполнили и по-разному
Te3Ka - Илья Новичихин: Да, мы второй.
Крылов Андрей: в домашке аж 5 задач сегодня
Крылов Андрей: произведение матриц
Крылов Андрей: трехмерный массив
Крылов Андрей: ну красота
Te3Ka - Илья Новичихин: +
ActaviuS: ++
Василий Горулев: 1 зал
Крылов Андрей: +
Te3Ka - Илья Новичихин: У меня через cwitch-case
ActaviuS: ++
Крылов Андрей: +
ActaviuS: уневерсальное есть
Крылов Андрей: а если не от 0, то надо вначале найти мин, потом макс, и посчитать видимо
Крылов Андрей: точно
Крылов Андрей: а можете быстро рассказать как форич работает?
Крылов Андрей: спасибо, надо будет попробовать) поехали дальше)
//Григорий Вахмистров: Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
//Крылов Андрей: у меня есть, но я честно смотрел по лекции
// Рисуем треугольник паскаля

int row = 10;
int[,] triangle = new int[row, row];
const int cellWidth = 5;

void FillTriangle()
{
for (int i = 0; i < row; i++)
{
triangle[i, 0] = 1;
triangle[i, i] = 1;
}
for (int i = 2; i < row; i++)
{
for (int j = 1; j <= i; j++)
{
triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
}
}
}

void PrintTriangle()
{
int col = cellWidth * row;
for (int i = 0; i < row; i++)
{
for (int j = 0; j < row; j++)
{
Console.SetCursorPosition(col, i +1);
if (triangle[i, j] != 0) Console.Write($"{triangle[i, j], cellWidth}");
col += cellWidth * 2;
}
col = cellWidth * row - cellWidth * (i+1);
Console.WriteLine();
}
}

FillTriangle();
PrintTriangle();



