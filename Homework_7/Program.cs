// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*double[,] FillArray (int lenM, int lenN)
{
    double[,] array = new double[lenM, lenN];
    for (int rows = 0; rows < lenM; rows++)
    {   
        for (int columns = 0; columns < lenN; columns++)
        {    
        array[rows, columns] = Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray (double[,] array)
{
    Console.Write("Получившийся массив:");
    Console.WriteLine();
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {   
        for (int columns = 0; columns < array.GetLength(1); columns++)    
        {
        Console.Write($"{array[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива: количество строк");
int lenghtM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность массива: количество столбцов");
int lenghtN = Convert.ToInt32(Console.ReadLine());
double[,] arrayMN = FillArray(lenghtM, lenghtN);
PrintArray(arrayMN);*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int[,] FillArray (int lenM, int lenN, int minValue, int maxValue)
{
    int[,] array = new int[lenM, lenN];
    for (int rows = 0; rows < lenM; rows++)
    {   
        for (int columns = 0; columns < lenN; columns++)
        {    
        array[rows, columns] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    Console.Write("Получившийся массив:");
    Console.WriteLine();
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {   
        for (int columns = 0; columns < array.GetLength(1); columns++)    
        {
        Console.Write($"{array[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

string FindElement (int[,] array, int fRow, int fColumn)
{
    string result = String.Empty;
    if (fRow > array.GetLength(0) - 1 || fColumn > array.GetLength(1) - 1) return result = "Такого элемента нет";
    else return result = "Искомый элемент: " + Convert.ToString(array[fRow, fColumn]);
}

Console.WriteLine("Введите размерность массива: количество строк");
int lenghtM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность массива: количество столбцов");
int lenghtN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомую позицию: номер строки");
int findRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомую позицию: номер столбца");
int findColumn = Convert.ToInt32(Console.ReadLine());
int[,] arrayMN = FillArray(lenghtM, lenghtN, minValue, maxValue);
PrintArray(arrayMN);
string result = FindElement(arrayMN, findRow, findColumn);
Console.WriteLine(result);*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray (int lenM, int lenN, int minValue, int maxValue)
{
    int[,] array = new int[lenM, lenN];
    for (int rows = 0; rows < lenM; rows++)
    {   
        for (int columns = 0; columns < lenN; columns++)
        {    
        array[rows, columns] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    Console.Write("Получившийся массив:");
    Console.WriteLine();
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {   
        for (int columns = 0; columns < array.GetLength(1); columns++)    
        {
        Console.Write($"{array[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

void FindColumSrArifm (int[,] array)
{
   int sumColumn = 0;
   double srArifmColumn = 0;
   for (int columns = 0; columns < array.GetLength(1); columns++)
    {   
        for (int rows = 0; rows < array.GetLength(0); rows++)    
        {
        sumColumn = sumColumn + array[rows, columns];
        }
        double sumColumnD = Convert.ToDouble(sumColumn);
        double countColumnD = Convert.ToDouble(array.GetLength(0));
        srArifmColumn = Math.Round((sumColumnD / countColumnD), 1);
        Console.WriteLine($"Среднее арифметическое {columns} столбца равно: {srArifmColumn}");
        sumColumn = 0;
    }
}

Console.WriteLine("Введите размерность массива: количество строк");
int lenghtM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность массива: количество столбцов");
int lenghtN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] arrayMN = FillArray(lenghtM, lenghtN, minValue, maxValue);
PrintArray(arrayMN);
FindColumSrArifm(arrayMN);