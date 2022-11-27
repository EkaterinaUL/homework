// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*int FindExtent (int a, int b)
{
    int ext = 1;
    for (int i = 1; i <= b; i++)
    {
        ext = ext * a;
    }
    return ext;
}

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int result = FindExtent(a, b);
Console.WriteLine(result);*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum (int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int result = FindSum(n);
Console.WriteLine($"Сумма цифр числа {n} равна {result}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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

Console.WriteLine("Введите длину массива");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minV = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxV = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len, minV, maxV);
PrintArray(array);*/
