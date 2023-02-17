//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);// 27
Console.WriteLine($"Ваше случайное число: {number}");

int digit1 = number/100;
int digit2 = number%10;

int digit3 = digit1*10+digit2;
    Console.Write($"Итоговое число: {digit3}");
