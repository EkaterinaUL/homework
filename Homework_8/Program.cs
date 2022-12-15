// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] FillArray (int lenM, int lenN, int minValue, int maxValue)
// {
//     int[,] array = new int[lenM, lenN];
//     for (int rows = 0; rows < lenM; rows++)
//     {   
//         for (int columns = 0; columns < lenN; columns++)
//         {    
//         array[rows, columns] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void PrintArray (int[,] array)
// {
//     Console.Write("Получившийся массив:");
//     Console.WriteLine();
//     for (int rows = 0; rows < array.GetLength(0); rows++)
//     {   
//         for (int columns = 0; columns < array.GetLength(1); columns++)    
//         {
//         Console.Write($"{array[rows, columns]} ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] OrderElements (int[,] array)
// {
//     for (int rows = 0; rows < array.GetLength(0); rows++)
//     {   
//         for (int columns = 0; columns < array.GetLength(1); columns++)    
//         {
//             int temp;
//             for (int columnsSort = columns + 1; columnsSort < array.GetLength(1); columnsSort++)    
//             {
//                 if (array[rows, columns] < array[rows, columnsSort])
//                 {
//                 temp = array[rows, columns];
//                 array[rows, columns] = array[rows, columnsSort];
//                 array[rows, columnsSort] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите размерность массива: количество строк");
// int lenghtM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность массива: количество столбцов");
// int lenghtN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] arrayMN = FillArray(lenghtM, lenghtN, minValue, maxValue);
// PrintArray(arrayMN);
// int[,] arrayOrder = OrderElements(arrayMN);
// PrintArray(arrayOrder);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] FillArray (int lenM, int lenN, int minValue, int maxValue)
// {
//     int[,] array = new int[lenM, lenN];
//     for (int rows = 0; rows < lenM; rows++)
//     {   
//         for (int columns = 0; columns < lenN; columns++)
//         {    
//         array[rows, columns] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void PrintArray (int[,] array)
// {
//     Console.Write("Получившийся массив:");
//     Console.WriteLine();
//     for (int rows = 0; rows < array.GetLength(0); rows++)
//     {   
//         for (int columns = 0; columns < array.GetLength(1); columns++)    
//         {
//         Console.Write($"{array[rows, columns]} ");
//         }
//     Console.WriteLine();
//     }
// }

// int FindRows (int[,] array, int maxValue)
// {
//     int minSumRows = maxValue * array.GetLength(1);
//     int minRows = 0;
//     for (int rows = 0; rows < array.GetLength(0); rows++)
//     {   
//         int sumRows = 0;
//         for (int columns = 0; columns < array.GetLength(1); columns++)    
//         {
//             sumRows = sumRows + array[rows, columns];
//         }
//         if (sumRows < minSumRows) 
//         {
//             minRows = rows;
//             minSumRows = sumRows;
//         }
//     }
//     return minRows;
// }


// Console.WriteLine("Введите размерность массива: количество строк");
// int lenghtM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность массива: количество столбцов");
// int lenghtN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] arrayMN = FillArray(lenghtM, lenghtN, minValue, maxValue);
// PrintArray(arrayMN);
// int minRowArray = FindRows(arrayMN, maxValue);
// Console.WriteLine($"{minRowArray + 1} строка является строкой с наименьшей суммой элементов");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] FillArray (int lenM, int lenN, int minValue, int maxValue)
// {
//     int[,] array = new int[lenM, lenN];
//     for (int rows = 0; rows < lenM; rows++)
//     {   
//         for (int columns = 0; columns < lenN; columns++)
//         {    
//         array[rows, columns] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void PrintArray (int[,] array)
// {
//     Console.Write("Получившаяся матрица:");
//     Console.WriteLine();
//     for (int rows = 0; rows < array.GetLength(0); rows++)
//     {   
//         for (int columns = 0; columns < array.GetLength(1); columns++)    
//         {
//         Console.Write($"{array[rows, columns]} ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] MultipliedArray (int[,] firstArray, int[,] secondArray)
// {
//     int[,] array = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
//     for (int columns = 0; columns < secondArray.GetLength(1); columns++)
//     {    
//         for (int rows = 0; rows < firstArray.GetLength(0); rows++)
//         {
//             int composition = 0;
//             for (int j = 0; j < secondArray.GetLength(0); j++)
//             {
//                 composition = composition + firstArray[rows, j] * secondArray[j, columns];
//             }
//             array[rows, columns] = composition;
//             }
//         }
//     return array;
// }


// Console.WriteLine("Введите размерность первой матрицы: количество строк");
// int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность первой матрицы: количество столбцов");
// int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int minValueFirstMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int maxValueFirstMatrix = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность второй матрицы: количество строк");
// int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность второй матрицы: количество столбцов");
// int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int minValueSecondMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int maxValueSecondMatrix = Convert.ToInt32(Console.ReadLine());

// if (rowsFirstMatrix != columnsSecondMatrix) Console.WriteLine ("Размерность матриц введена некорректна: количество строк первой матрицы должно быть равно количеству столбцов второй матрицы");
// else
// {
//     int[,] arrayFirst = FillArray(rowsFirstMatrix, columnsFirstMatrix, minValueFirstMatrix, maxValueFirstMatrix);
//     PrintArray(arrayFirst);
//     int[,] arraySecond = FillArray(rowsSecondMatrix, columnsSecondMatrix, minValueSecondMatrix, maxValueSecondMatrix);
//     PrintArray(arraySecond);
//     int[,] newArray = MultipliedArray(arrayFirst, arraySecond);
//     PrintArray (newArray);
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] FillArray (int len)
// {
//     int[,,] array = new int[len, len, len];
//     for (int i = 0; i < len; i++)
//     {   
//         for (int j = 0; j < len; j++)
//         {    
//             for (int k = 0; k < len; k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
//     return array;
// }

// void PrintArray (int[,,] array)
// {
//     Console.Write("Получившийся массив:");
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {   
//         for (int j = 0; j < array.GetLength(0); j++)
//         {    
//             for (int k = 0; k < array.GetLength(0); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
//             }
//         Console.WriteLine();
//         }
//     }
// }

// Console.WriteLine("Введите размерность массива");
// int lenght = Convert.ToInt32(Console.ReadLine());

// int[,,] newArray = FillArray(lenght);
// PrintArray(newArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray (int countRowsColumns)
{
    int[,] array = new int[countRowsColumns, countRowsColumns];
    int value = 1;
    for (int rows = 0; rows < 1; rows++)
    {   
        for (int columns = 0; columns < countRowsColumns; columns++)
        {    
            array[rows, columns] = value;
            value++;
        }
    }
    
    for (int rows = 1; rows < countRowsColumns; rows++)
    {   
        int columns = countRowsColumns - 1;
        array[rows, columns] = value;
        value++;
    }

    int countColumns = countRowsColumns;
    for (int rows = countRowsColumns - 1; rows > 0; rows--)
    {   
        
        for (int columns = countColumns - 2; columns > -1; columns--)
        {    
            array[rows, columns] = value;
            value++;
        }
        countColumns = countColumns - 2;    
    }
    
    for (int columns = 0; columns < countRowsColumns - 1; columns++)
    {  
        int rows = 1;
        array[rows, columns] = value;
        value++;
    }
    
    for (int rows = 2; rows < countRowsColumns-1; rows++)
    {   
        for (int columns = 2; columns > 0; columns--)
        {  
        array[rows, columns] = value;
        value++;
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
            Console.Write("{0,3} ", array[rows, columns]);
        }
        Console.WriteLine();
    }
}

// Console.WriteLine("Введите размерность массива");
int rowsColumns = 4;

int[,] newArray = FillArray(rowsColumns);
PrintArray(newArray);