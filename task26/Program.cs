// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.Write("Введите длину стороны А треугольника: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длину стороны В треугольника: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длину стороны С треугольника: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A+B>C && A+C>B && B+C>A)
{
    System.Console.WriteLine("С такими сторонами труегольник существует");
}
else
{
 System.Console.WriteLine("С такими сторонами труегольника не существует");
}