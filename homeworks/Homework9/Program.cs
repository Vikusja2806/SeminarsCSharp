/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int FindSum(int n, int m)
{
    
    while(m!=n)
    {
                  
      if(n > m)
      { 
        int sum = n;       
        sum = sum + FindSum(n - 1, m);
        return sum;
      } 
      else
      { 
        int sum = m;
        sum = sum + FindSum(m - 1,n);
        return sum;
      }
    }    
    return m;
}
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = FindSum(n, m);
Console.Write(result);
*/

/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int FunctionAkkerman(int m, int n)
{
    if(m==0)
    { 
      return n + 1;
    }
    else
    if(n==0 && m > 0)
    {
        return FunctionAkkerman(m-1,1);
    }  
    else
    if(m>0 && n>0)
    {
        return FunctionAkkerman(m-1, FunctionAkkerman(m, n-1));  
    }
    return 1;
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());  

int result = FunctionAkkerman(m, n);
Console.Write(result);
*/  












