/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
       newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindEvenNumbers(int[] array)
{
    int count = 0;

    for(int i=0; i < array.Length; i++)
    {
        if( array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a);

ShowArray(myArray);

Console.WriteLine($"Количество четных чисел в массиве равно {FindEvenNumbers(myArray)}");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
       newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumDigitUnevenIndex(int[] array)
{
    int sum = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum = sum + array[i];
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число для массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a, min, max);

ShowArray(myArray);

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {SumDigitUnevenIndex(myArray)}");
*/
/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i} element of the array: "); //Запрашивает элементы массивв у пользователя 
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

int FindMinMaxElement(int[] array)
{
    int minDigit = array[0];
    int maxDigit = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxDigit)     maxDigit = array[i];
                
           if(array[i] < minDigit)  minDigit = array[i];
        
    }
    int diff = maxDigit - minDigit;

    return diff;

}
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateArray(a);

ShowArray(myArray);

Console.WriteLine($"Разница между максильмальным и минимальным числом в массиве равна {FindMinMaxElement(myArray)}");

*/
