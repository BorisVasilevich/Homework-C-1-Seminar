

//Console.Write("Введите длинну массива ");
//int t = Convert.ToInt32(Console.ReadLine());


double [] array = new double [6];


double [] raisearray(double [] array)
{
    for (int i = 0; i < array.Length;i++){
    array [i] = new Random().Next(1, 49);
    }
    return array;
}

void PrintArray(double [] array)
{
    int i =0;
    Console.Write($"Итоговый массив: [  {array[i]}");
    for (i = 1;i < array.Length;i++)
    {
Console.Write($", {array[i]}");
    }
    Console.Write(" ] ");
    Console.WriteLine();
    return;
}

raisearray(array);

PrintArray(array);

//Григорий Вахмистров  кому  Все 20:08
// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

int[] RevertArray(int[] array) {
    int[] result = new int[array.Length];

    for(int i = 0; i < array.Length; i++) {
        result[array.Length - i - 1] = array[i];
    }

    return result;
}


int[] array = GenerateArr(12, -9, 9);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);

int[] result = RevertArray(array);
Console.WriteLine("Перевёрнутый массив");
PrintArray(result);



/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

System.Console.Write("Введите десятичное число: ");
int num = getVar();
int tmpNum = num;
int count = 0;

while (tmpNum > 0) {   
    count++;
    tmpNum /= 2;
}

tmpNum = num;
int[] arrNum = new int[count];
for (int i = arrNum.Length; i > 0; i--) {
    arrNum[i-1] = tmpNum % 2;
    tmpNum /= 2;
}

printArr(num, arrNum);

// --- FUNCs --- //
int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите проверяемое число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);
        
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}

void printArr(int num, int[] nums){
    System.Console.Write($"{num} -> {String.Join("", nums)}\n");
}



//Volkov Aleksandr  кому  Все 20:14
System.Console.WriteLine("Введите число: ");
int input = 0;
int.TryParse(Console.ReadLine(), out input);

int[] FiboArray(int input) {
    int[] result = new int[input];
    result[0] = 0;
    result[1] = 1;
    result[2] = 1;
    for(int i = 3; i < input; i++) {
        result[i] = result[i-1] + result[i-2];
    }

    return result;
}

void printArr(int[] nums){
    System.Console.Write($"{String.Join(" ", nums)}\n");
}

printArr(FiboArray(input));
//Volkov Aleksandr  кому  Все 20:22
int[] CopyArray(int[] inpArr) {
    int[] result = new int[inpArr.Length];
    for(int i = 0; i < result.Length; i++) {
        result[i] = inpArr[i];
    }
    return result;
}

int[] GenerateArray(int array_Size) {
    int[] result = new int[array_Size];
    Random tmp = new Random();
    for(int i = 0; i < array_Size; i++) {
        result[i] = tmp.Next(100, 1000);
    }

    return result;
} 

void printArr(int[] nums){
    System.Console.Write($"{String.Join(" ", nums)}\n");
}

System.Console.WriteLine("Введите размер массива");
int input = 0; 
int.TryParse(Console.ReadLine(), out input);
int[] arr1 = GenerateArray(input);
System.Console.WriteLine("Исходный массив");
printArr(arr1);
int[] copy = CopyArray(arr1);
System.Console.WriteLine("Копия массива");
printArr(copy);



Console.WriteLine("Enter the number of Fibonacci numbers to generate: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1, c;

Console.Write(a + ", ");
Console.Write(b + ", ");

for (int i = 2; i < n; i++)
{
    c = a + b;
    Console.Write(c + ", ");
