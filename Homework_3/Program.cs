// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*int CheckPalindrom(int number)
{
    int ed = number % 10;
    int dec = (number/10) % 10;
    int tys = (number/1000) % 10;
    int dtys = (number/10000) % 10;
    
    if (dec == tys && ed == dtys)
    {
        int q = 1;
        return q;
    }
    else
    {
        int q = 0;
        return q;  
    }
}
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int result = CheckPalindrom(num);
if (result == 1) 
{
    Console.WriteLine($"Число {num} является палидромом");
}
else 
{
    Console.WriteLine($"Число {num} не является палидромом");
}
*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Расстояние между двумя точками равно квадратному корню из суммы квадратов разностей координат по каждой оси.

/*double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Round(Math.Sqrt(((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((z2-z1)*(z2-z1))));
    return dist;
}

Console.WriteLine("Введите координат X первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат Z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координат X второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат Z второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между двумя точками равно {result}");*/

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void MetodCube(int number)
{
    int count = 1;
    while (count <= number)
    {
        int cube = count*count*count;
        Console.WriteLine(cube);
        count++;
    }
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
MetodCube(n);