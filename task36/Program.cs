// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for(int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int SumOfOddNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1 || array[i] % 2 == -1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = FillArray(4, -99, 99);
PrintArray(array);
int sum = SumOfOddNumbers(array);
Console.WriteLine(sum);