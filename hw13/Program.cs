﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend (int weekDay)
{
    if (weekDay < 5)
    {
       return true;
    }
    return false;
}

bool ValidateWeekday (int number)
{
    if (number > 0 && number <= 7)
    {
       return true;
    }
    System.Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите день недели: ");
if (ValidateWeekday (weekDay))
{
    if (IsWeekend (weekDay))
    {
        System.Console.WriteLine("Выходной");
    }
    else
    {
    System.Console.WriteLine("Не выходной");
    }
}
