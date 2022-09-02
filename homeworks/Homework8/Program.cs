/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
    Console.WriteLine();
}

int[,] SortDescendingRows(int[,] array)
{
   for(int i =0; i < array.GetLength(0); i++) 
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k =0; k < array.GetLength(1); k++)    
            {
                if(array[i,j] > array[i,k])
                {
                   int temp = array[i, j];
                   array[i, j] = array[i, k];
                   array[i, k] = temp;
                }
            }            
    return array;
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

myArray = SortDescendingRows(myArray);
Show2dArray(myArray);
*/
/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    Console.WriteLine();
}
      
int[] FindSumRow(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for(int i =0; i < array.GetLength(0); i++)
    {
        sumRow[i] = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sumRow[i] = sumRow[i] + array[i, j];
    } 
    return sumRow;
}      

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindMinRow(int[] array)
{
    int minRowIndex = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[minRowIndex])
          minRowIndex = i;
    } 
    return minRowIndex; 
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

int[] sumRow = FindSumRow(myArray);
ShowArray(sumRow);
int rowIndex = FindMinRow(sumRow);

Console.WriteLine($"Минимальная сумма в строке с индексом {rowIndex}" );
*/
/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
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
    Console.WriteLine();
}

int[,] FindMatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < newArray.GetLength(0); i++)
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
           int sum = 0;
           for(int k = 0; k < newArray.GetLength(1); k++)
           {
            sum = sum + firstMatrix[i,k] * secondMatrix[k,j];
           }
           newArray[i,j] = sum;
        }
    return newArray;
}

Console.Write("Введите количество строк первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для матрицы: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для матрицы: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первая матрица:");
int[,] firstMatrix = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(firstMatrix);

Console.WriteLine("Вторая матрица:");
int[,] secondMatrix = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(secondMatrix);

Console.WriteLine("Произведение матриц:");
int[,] finishMatrix =  FindMatrixProduct(firstMatrix, secondMatrix, rows, columns);
Show2dArray(finishMatrix);
*/
/*
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,]CreateSnakeArray(int size)
{
   int[,] array = new int[size, size];

   int count = 1;
   int i = 0;
   int j = 0;

    while (count <= size * size)
   {
       array[i, j] = count;
       count++;
       if (i <= j + 1 && i + j < array.GetLength(1) - 1)
       j++;
       else if (i < j && i + j >= array.GetLength(0) - 1)
       i++;
       else if (i >= j && i + j > array.GetLength(1) - 1)
       j--;
       else
       i--;
    }
   return array; 
}

void Show2dArray (int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] snakeArray = CreateSnakeArray(size);
Show2dArray(snakeArray);

*/
