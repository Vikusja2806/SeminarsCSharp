/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomDoubleArray(int rows, int columns,int minValue, int maxValue)
{
    double[,] newArray = new double[rows,columns];

    for (int i = 0; i < rows ; i++)
    {
        for (int j = 0; j < columns; j++)
        {            
            newArray[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 1);
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)                  
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandomDoubleArray(m, n, min, max);
Show2dArray(myArray);
*/
/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{                                                                        
   int[,] newArray = new int[rows, columns]; 
   for(int i = 0; i < rows; i++)                                          
   {
      for(int j = 0; j < columns; j++)                                 
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);        
      }
   }
   return newArray;
}                                                            

void Show2dArray(int[,] array)                  
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

void FindDesiredElement(int[,] array, int rowsElement, int columnsElement)
{
    int desireNumber = array[0, 0];
    for(int i = 0; i < array.GetLength(0); i++)
    { 
        for(int j = 0; j < array.GetLength(1); j++)
        {
        
            if((i == rowsElement) && (j == columnsElement))  
            {
                desireNumber = array[i,j];
                Console.WriteLine($"Искомым элементом является: {desireNumber}");
            }
        }
    }

    if((rowsElement > array.GetLength(0)) || (columnsElement > array.GetLength(1)) )
    {
       Console.WriteLine("Такого элемента нет!"); 
    }  
       
}
  
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows Element: ");
int numrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns Element: ");
int numcolumns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
FindDesiredElement(myArray, numrows, numcolumns);
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{                                                                        
   int[,] newArray = new int[rows, columns]; 
   for(int i = 0; i < rows; i++)                                          
   {
      for(int j = 0; j < columns; j++)                                 
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);        
      }
   }
   return newArray;
}                       
void Show2dArray(int[,] array)                  
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

double[] FindAverageInColumns(int[,] array)
{
    double[] arrayColumn = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        arrayColumn[j] = sum / array.GetLength(0);
    } 
    return arrayColumn;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Console.WriteLine();
double[] result = FindAverageInColumns(myArray);
Console.Write("Среднее арифметическое каждого столбца: "); ShowArray(result);
*/
