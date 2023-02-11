// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
{int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
if (index == 1)
{
    index += 1;
}
while (index <= N)
{
   Console.WriteLine (index);
   index += 2;
}
}
