/*
// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return 0;
}
Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(xA, yA);

if(quartNum == 0)
    Console.WriteLine("Point on the axes!");
else
    Console.WriteLine($"Point is located on {quartNum} quart.");

*/
/*
// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void FindCooardinats(int quart)
{
    if(quart == 1)
    Console.WriteLine("Диапазон (x+, y+)");
    if(quart == 2)
    Console.WriteLine("Диапазон (x-, y+)");
    if(quart == 3)
    Console.WriteLine("Диапазон (x-, y-)");
    if(quart == 4)
    Console.WriteLine("Диапазон (x+, y-)");
}
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
FindCooardinats(quarter);
*/
/*
// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    
}

Console.Write("Введите координаты первой точки по оси X1 : ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y1 : ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X2 : ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Y2 : ");
double Yb = Convert.ToDouble(Console.ReadLine());

double coordinate = FindDistance(Xa, Ya, Xb, Yb);
Console.Write($"Distance is {coordinate}");
*/
/*
// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.

void ShowSquare(int N)
{
    int current = 1;
    while(current <= N)
    {
        Console.WriteLine($"Квадрат числа {current} = {current*current}");
        current++;
    }    
}

Console.Write("Веедите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowSquare(number);
*/
