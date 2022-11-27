// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] FillArray (int len)
{
    int[] array = new int[len];
    for (int i=0; i < len; i++)
    {       
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i=0; i < array.Length; i++)
    {       
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindCountEven (int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {       
        if (array[i] % 2 ==0) count ++;
    }
    return count;
}

Console.WriteLine("Введите длину массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len);
PrintArray(array);
int countEven = FindCountEven(array);
Console.WriteLine($"Количество четных чисел в массиве: {countEven}");*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] FillArray (int len, int minValue, int maxValue)
{
    int[] array = new int[len];
    for (int i=0; i < len; i++)
    {       
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i=0; i < array.Length; i++)
    {       
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSumOddPosition (int[] array)
{
    int sumOddPos = 0;
    for (int i=1; i < array.Length; i=i+2)
    {       
        sumOddPos = sumOddPos + array[i];
    }
    return sumOddPos;
}

Console.WriteLine("Введите длину массива");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minV = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxV = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len, minV, maxV);
PrintArray(array);
int sumOddPos = FindSumOddPosition(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumOddPos}");*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray (int len)
{
    double[] array = new double[len];
    for (int i=0; i < len; i++)
    {       
        array[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i=0; i < array.Length; i++)
    {       
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindDiffMaxMin (double[] array)
{
    double diffMaxMin = 0;
    double Max = array[0];
    double Min = array[0];
    for (int i=0; i < array.Length; i++)
    {       
        if (array[i] > Max) Max = array[i];
        if (array[i] < Min) Min = array[i];
    }
    diffMaxMin = Math.Round(Max - Min, 2);
    return diffMaxMin;
}

Console.WriteLine("Введите длину массива");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(len);
PrintArray(array);
double diff = FindDiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diff}");