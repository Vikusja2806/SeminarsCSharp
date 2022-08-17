/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int RaiseToGrade(int num, int n)
{
  int num_n=1;
  for(int i=0; i<n; i++) 
   {
    num_n = num_n * num;
   }
   return num_n;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

int grade = RaiseToGrade(A, B);

Console.WriteLine($"Число {A} в степени {B} равно {grade}");
*/

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum(int number)
{
     
    int sum = 0;
    while (number != 0)
    {
        int lastDigit = number % 10;
        sum = sum + lastDigit;
        number = number / 10;
    }
    return(sum);
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine(result);
*/
/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] RandomArray(int min, int max)
{
    int size = 8;
    int[] arrayNew = new int[size];

    for (int i = 0; i < size; i++)
    arrayNew[i] = new Random().Next(min, max);
    return arrayNew;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Введите минимальное значение для массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение для массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int [] resultArray = RandomArray(minimum, maximum);

PrintArray(resultArray);

*/


