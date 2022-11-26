// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*char FindSecondNumber (string number)
{
    char s = number[1];
    return s;
}

Console.WriteLine("Введите трёхзначное число");
string num = Console.ReadLine();
char second = FindSecondNumber(num);
Console.WriteLine(second);*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
string FindThird (string number)
{
    int l = number.Length;
    int count = 2;
    if (l < count + 1)
    {
        string s = "Третьей цифры нет";
        return s;
    }
    else
    {
        string s = Convert.ToString(number[count]);
        return s;
    }
}
Console.WriteLine("Введите число");
string num = Console.ReadLine();
string result = FindThird(num);
Console.WriteLine(result);

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*bool FindWeekend (int number)
{
    if (number == 6 | number == 7) 
    {
        return true;
    }
    else 
    {
        return false;
    }
}
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
bool result = FindWeekend(num);
Console.WriteLine(result);*/