/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumbers(int number)
{
    int sot = number % 100;
    
    return sot / 10;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int newNumber = CutNumbers(number);
Console.Write($"Вторая цифра числа {number} это {newNumber}");
*/
/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int MakeThreeDigitNumber(int number)
{
    while(number >= 1000)
    {
        number = number / 10;
    }
    return number;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberNew = MakeThreeDigitNumber(number);
if(number <= 99)
    {
        Console.WriteLine($"Третьей цифры в числе {number} нет.");
    }
else
{
    int ThirdNumber = numberNew % 10;
    Console.Write($"Третья цифра числа {number} это {ThirdNumber}.");
}
*/
/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void FindWeekenddays(int number)
{
    if(number > 5)
       Console.Write("Да");
    else
       Console.Write("Нет");
}

Console.Write("Введите число от 1 до 7, обозначающее день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

FindWeekenddays(num);
*/