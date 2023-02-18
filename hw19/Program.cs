// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());
int len = number.Length;

if (len == 5)
{
    if (number [0] == number [4] && number [1] == number [3])
    {
        Console.Write("да");
    }
    else
    {
        Console.Write("Нет");
    }
}
else
    {
        Console.Write("Введено не пятизначное число");
    }