/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} число: "); //Запрашивает элементы массивв у пользователя 
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindCountPositiveDigit(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {   
       if(array[i] > 0 )
       count++;
    }
    return count;
}

Console.Write("Введите размер: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
Console.WriteLine(FindCountPositiveDigit(myArray));
*/
/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
   double x = (b1-b2)/(k2-k1);
   double y1 = k1 * x + b1; 
   double y2 = k2 * x + b2;                               
   if(k1==k2 || y1 != y2)  Console.Write("Заданные прямые не пересекаются!");
   else
   Console.Write($"Точка пересечения заданных прямых: ({x}; {y1})");
}

Console.Write("Введите b1: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double d = Convert.ToDouble(Console.ReadLine());

FindIntersectionPoint(a,b,c,d);
*/