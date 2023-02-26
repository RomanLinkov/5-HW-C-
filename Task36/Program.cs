// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int lngth = NumberInput("Введите длину массива: ");
int min = NumberInput("Введите минимальный элемент массива: ");
int max = NumberInput("Введите максимальный элемент массива: ");

int[] nums = ArrayGeneration(lngth, min, max+1);

int sumOddPositions=SumOddPositions(nums);

Console.Write("[");
PrintArray(nums);
Console.Write($"] -> ");
Console.WriteLine($"{sumOddPositions}");


int SumOddPositions(int[] c)
{
    int lngth = c.Length;
    int res = c[1];
    for (int i=3; i<lngth;i=i+2)
    {
        res=res+c[i];
    }
    return res;
}

void PrintArray(int[] a)
{
    
    for (int i=0; i<a.Length;i++)
    {
        Console.Write($"{a[i]}");
        if (i<a.Length-1)Console.Write($", ");
    }
    
}

int[] ArrayGeneration(int lngth, int min, int max)
{
    int[] array = new int[lngth];
    Random rand = new Random();
    for (int i = 0; i<lngth;i++)
    {
        int value = rand.Next(min,max+1);
        array[i] = value;
    }
    return array;
}

int NumberInput(string msg)

{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}