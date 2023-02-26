// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

int lngth = NumberInput("Введите длину массива: ");
int min = NumberInput("Введите минимальный элемент массива: ");
int max = NumberInput("Введите максимальный элемент массива: ");

double[] nums = DoubleArrayGeneration(lngth, min, max);

double difMaxMin=DoubleArrayFindMax(nums)-DoubleArrayFindMin(nums);

Console.Write("[");
PrintArrayDouble(nums);
Console.Write($"] -> ");
Console.WriteLine($"{Math.Round(difMaxMin,1)}");


double DoubleArrayFindMax(double[] array1)
{
    int lngth = array1.Length;
    double res = array1[0];
    for (int i=1; i<lngth;i++)
    {
        if (res<array1[i]) res = array1[i];
    }
    return res;
}

double DoubleArrayFindMin(double[] array2)
{
    int lngth = array2.Length;
    double res = array2[0];
    for (int i=1; i<lngth;i++)
    {
        if (res>array2[i]) res = array2[i];
    }
    return res;
}

void PrintArrayDouble(double[] a)
{
    
    for (int i=0; i<a.Length;i++)
    {
        Console.Write($"{Math.Round(a[i],1)}");
        if (i<a.Length-1)Console.Write($"; ");
    }
    
}

double[] DoubleArrayGeneration(int lngth, int min, int max)
{
    double[] array = new double[lngth];
    max=max+1;
    Random rand = new Random();
    for (int i = 0; i<lngth;i++)
    {
        double value = rand.NextDouble()*(max-min)+min;
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