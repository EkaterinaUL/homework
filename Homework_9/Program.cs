// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNumber(int number)
// {
//     if (number > 0)
//     {
//         Console.Write(number + " ");
//         PrintNumber(number-1);
//     }
// }
// PrintNumber(18);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSumElements(int valueM, int valueN)
// {
//     int sum = 0;
//     if (valueM != valueN)
//     {
//         if (valueM < valueN)
//         {
//             return sum = FindSumElements(valueM, valueN - 1) + valueN;
//         }
//         else
//         {
//             return sum = FindSumElements(valueN, valueM - 1) + valueM;
//         }
//     }
//     return valueM;
// }

// Console.WriteLine("Введите значение M");
// int valM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N");
// int valN = Convert.ToInt32(Console.ReadLine());

// int result = FindSumElements(valM, valN);
// Console.WriteLine(result);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int functionAckermann(int valueN, int valueM)
{
    int result = 0;
    if (valueN == 0) return result = valueM + 1;
    else
    {
        if (valueN > 0 && valueM == 0)
        {
            return result = functionAckermann(valueN - 1, 1);
        } 
        else
        {
            return result = functionAckermann(valueN - 1, functionAckermann(valueN, valueM - 1));
        }
    }
}

Console.WriteLine("Введите значение N");
int valN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение M");
int valM = Convert.ToInt32(Console.ReadLine());

if (valN < 0 || valM < 0) Console.WriteLine("Некорректно введены значения m и n");
else
{
    int result = functionAckermann(valN, valM);
    Console.WriteLine(result);
}