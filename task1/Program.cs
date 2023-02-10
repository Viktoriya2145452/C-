Console.WriteLine("Введите число a: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = 0;
square = number2 * number2;
if (square == number1) 
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
