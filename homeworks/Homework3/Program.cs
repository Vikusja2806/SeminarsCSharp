/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void FindPalindrome (int number)
{
    if(number / 10000 == number % 10)
    {
        int firstNumber = number / 1000;
        int n1 = firstNumber % 10;
        int secondNumber = number % 100;
        int n2 = secondNumber / 10;
           if(n1 == n2)
           {
            Console.Write("Yes");
           }
    }
    else
    {
        Console.Write("No");
    }
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindPalindrome(num);
*/
/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    
}

Console.Write("Введите координаты первой точки по оси X1 : ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y1 : ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Z1 : ");
double Za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X2 : ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y2 : ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Z2 : ");
double Zb = Convert.ToDouble(Console.ReadLine());

double coordinate = FindDistance(Xa, Ya, Za, Xb, Yb, Zb);
Console.Write($"Distance is {coordinate}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void ShowCube(int N)
{
    int current = 1;
    while(current <= N)
    {
        Console.WriteLine($" Таблица кубов для числа {current} = {current*current*current}");
        current++;
    }    
}

Console.Write("Веедите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCube(number);
*/