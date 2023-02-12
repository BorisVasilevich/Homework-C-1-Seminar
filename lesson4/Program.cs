//Te3Ka - Илья Новичихин  кому  Все 19:55
int[] RandomeArray(int[] arrayNew)
{
    for(int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = new Random().Next(0, 2);
    }
    return arrayNew;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Программа выводит массив из 8 элементов,"
+ "заполненный 0 и 1 в случайном порядке.");

int[] array = new int[8];
RandomeArray(array);
PrintArray(array);
int[] RandomeArray(int[] arrayNew)
{
    for(int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = new Random().Next(0, 2);
    }
    return arrayNew;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Программа выводит массив из 8 элементов,"
+ "заполненный 0 и 1 в случайном порядке.");

int[] array = new int[8];
RandomeArray(array);
PrintArray(array);
//Oleg Prokopenko  кому  Все 20:02
//случайно)
//Наталья  кому  Все 20:03
//Олег
//Egor  кому  Все 20:04
int[] EnterArray(int N){
int[] array = new int[N];
int len = array.Length;
for (int i = 0; i < len; i++)
{
   array[i] = new Random().Next(0,2);
}
return array;
}

void PrintArray(int[] array){
int len = array.Length;
System.Console.Write("[");
for (int i = 0; i < len; i++)

{if (i == len -1)
   System.Console.Write($"{array[i]}]");
else System.Console.Write($"{array[i]},");
}
}



System.Console.WriteLine("Задача 28");
System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = EnterArray(N);
//int[] arr = {0,0,0,0,0,0,0,0};
System.Console.WriteLine("Ваш массив");
PrintArray(arr);
//Oleg Prokopenko  кому  Все 20:04
//А я отправил в общий, находясь в зале... Моё решение не видно?
//понял
//Egor  кому  Все 20:05
//только проверку размерности не сделали
//да
//Oleg Prokopenko  кому  Все 20:08
//нет
//я cotaruis)
//Evgenii Kolokoltsev  кому  Все 20:08
int[] array = new int[8];
void FillArray(int[] array)
    {
    Console.WriteLine($"Формируем массив из {array.Length} элементов");
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0, 2);
    }
    return;
    }

void PrintArray(int[] array)
    {
    int i = 0;
    Console.Write($"Итоговый массив: [ {array[i]}");
    for (i = 1; i < array.Length; i++)
    {
    Console.Write($", {array[i]}");
    }
    Console.Write(" ]");
    return;
    }

FillArray(array);
PrintArray(array);
//Egor  кому  Все 20:14
//натуральная степень то есть не отрицательная?
//Oleg Prokopenko  кому  Все 20:14
//math.Pow примут?)
//ясно, спасибо
//Evgenii Kolokoltsev  кому  Все 20:16
int[] array = new int[8];
void FillArray(int[] array)
    {
    Console.WriteLine($"Формируем массив из {array.Length} элементов");
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0, 2);
    }
    return;
    }

void PrintArray(int[] array)
    {
    int i = 0;
    Console.Write($"Итоговый массив: [ {array[i]}");
    for (i = 1; i < array.Length; i++)
    {
    Console.Write($", {array[i]}");
    }
    Console.Write(" ]");
    return;
    }

FillArray(array);
PrintArray(array);
//ActaviuS  кому  Все 20:20
int N = getVar();
System.Console.Write($"[{String.Join(",", genArr(N))}]\n");

// --- FUNC --- //
int[] genArr(int N){
    int[] arrNum = new int[N];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) {}

    return arrNum;
}

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}
//У меня чат очистился просто не видел
System.Console.Write($"[{String.Join(",", genArr(N))}]\n");
//вывод массива
//есть встроенная
//У меня вынесено за цикл
Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) {}
//ActaviuS  кому  Все 20:26
//так и зовут )
int N = getVar();
printArr(N);

// --- FUNC --- //
int[] genArr(int N){
    int[] arrNum = new int[N];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) {}

    return arrNum;
}

void printArr(int N){
    System.Console.Write($"[{String.Join(",", genArr(N))}]\n");
}

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}
//переписал
//Evgenii Kolokoltsev  кому  Все 20:29
//задача 25: целые оба числа ?
//Volkov Aleksandr  кому  Все 20:42
//за alt+shift+f спасибо))
//а я хотел в шутку написать как в паспорте))
//# ltkfnm NJ-nj




