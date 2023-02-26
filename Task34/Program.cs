// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int lngth = NumberInput("Введите длину массива: ");

int[] nums = ArrayGeneration(lngth, 100, 1000);

int quantEvenNumbers=QuantEvenNumbers(nums);

Console.Write("[");
PrintArray(nums);
Console.Write($"] -> ");
Console.WriteLine($"{quantEvenNumbers}");


int QuantEvenNumbers(int[] c)
{
    int lngth = c.Length;
    int res = 0;
    for (int i=0; i<lngth;i++)
    {
        if (c[i] % 2 == 0) res++;
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