string Text = (" - Правительство РФ продлевает отсрочку по уплате страховых  культуры и туризма, уже воспользовавшихся отсрочкой ранее.");

string Replace (string text; char old value; char new value);
{
    string result = string.Empty;
    int length = Text.Length;
    for (int i = 0; i < length; i++)
    {
    if (Text [i] == old value; result = result + $"{new value}");
    else (result + $"{str[i]}");
    }
    return result;
}
string new Text = Replace(Text,"т", "Т");
Console.WriteLine(new Text);


int [] arr = {1,5,6,8,2,3,1,2};

void Print.Array(int [] Array);
{
    int count = Array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{Array[i]}");
    }
    Console.WriteLine();
}
Print.Array(arr);

void SelectionSort(int [] Array)
{
    for (int i = 0; i < Array.Length-1; i++)
    {
        int min Position = i;
        for (int j = i + 1; j < Array[min Position])
        {
            min Position = j;
                    
        }
        int temporary = Array [i];
        Array[i] = Array [min Position];
        Array[min Position] = temporary;

    }
}