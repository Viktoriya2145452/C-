// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Pr(int number)
{
    int pr = 1;
    for(int i = 1; i <= number; i++)
    {
        pr=pr*i;
    }
    return pr;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до N = {Pr(N)}");
