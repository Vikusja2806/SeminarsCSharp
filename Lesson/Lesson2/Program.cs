﻿/*
// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if(ed > dec)
        max = ed;
    else
        max = dec;

    return max;
}


int randomNumber = new Random().Next(10,100);

int biggestDigit = FindBiggestDigit(randomNumber);
Console.Write($"Biggest digit of {randomNumber} is {biggestDigit}");

*/
/*
// Задача 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    
    return sot * 10 + ed;
}

int randomNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randomNumber);
Console.Write($"New version of {randomNumber} is {newNumber}");
*/
/*
// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

void IsDivisionable(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        Console.WriteLine($"{num2} is divisionable of {num2}");
    }
    else
    {
       Console.WriteLine($"{num2} is not divisionable {num1}. Reminder is {reminder}"); 
    }
}

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1, n2);

*/
/*
// Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool IsDivis(int number)
{
      return number % 7 == 0 && number % 23 == 0;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

bool isDivison = IsDivis(n);
Console.WriteLine(isDivison);
*/
