// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int[] FillArray (int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {       
        Console.WriteLine("Input numbes");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {       
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountPositive (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Input count numbes");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] arrayMNumbers = FillArray (lenghtArray);
PrintArray(arrayMNumbers);
Console.WriteLine($"Введено чисел больше 0: {CountPositive(arrayMNumbers)}");*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int[] FillArray (int countRates)
{
    int[] array = new int[countRates];
    for (int i = 0; i < countRates; i++)
    {       
        Console.WriteLine($"Input b1, k1 - b{countRates / 2}, k{countRates / 2}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

string PrintArray (int[] array)
{
    Console.Write("Получившиеся уравнения -> ");
    string urav = String.Empty;
    string bi = String.Empty;
    string ki = String.Empty;

    for (int i = 0; i < array.Length-1; i = i + 2)
    {   
        bi = Convert.ToString(array[i]);
        ki = Convert.ToString(array[i + 1]);
        urav = urav + ki + " * x + " + bi + "; ";
        //Console.Write(array[i + 1] + " * x + " , array[i]);
    }
    Console.WriteLine();
    return urav;
}

string FindPoint (int[] array)
{
    // k1 * x + b1 = k2 * x + b2
    int lastRatesB = array.Length - 2;
    int dividentB = array[lastRatesB];
    int dividerK = array[1];
    for (int i = 2; i < array.Length; i = i + 2)
    {       
        dividentB = dividentB - array[lastRatesB - i];
    }
     for (int i = 3; i < array.Length; i = i + 2)
    {       
        dividerK = dividerK - array[i];
    }
    double dB = Convert.ToDouble(dividentB);
    double dK = Convert.ToDouble(dividerK);
    double x = Math.Round(dB/dK, 2);
    double y = Math.Round(Convert.ToDouble(array[1] * x + array[0]), 2);
    string result = "(" + x + ", " + y + ")";
    return result;
}

Console.WriteLine("Введите количество прямых");
int countRates = 2 * (Convert.ToInt32(Console.ReadLine()));
int[] arrayRates = FillArray (countRates);
Console.WriteLine(PrintArray(arrayRates));
Console.WriteLine($"Точка пересечения {countRates / 2} прямых: {FindPoint(arrayRates)}");