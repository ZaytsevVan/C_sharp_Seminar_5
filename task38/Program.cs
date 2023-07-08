// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();
    for(int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return tempArray;
}

void PrintArray(double[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

double Max(double[] array)
{   
    double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = 0;
    double max = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    }
    min = max;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];
    }
    return min;
}

double MaxMinusMin(double max, double min)
{
    double maxMinusMin = Math.Round((max - min), 2);
    return maxMinusMin;
}

double[] array = FillArray(4, 0, 10);
PrintArray(array);
double max = Max(array);
double min = Min(array);
Console.WriteLine($"Максимальный элемент {max}, минимальный элемент {min}");
double maxMinusMin = MaxMinusMin(max, min);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {maxMinusMin}");