// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int Num(int n)
{
    string ns = n.ToString();
    return ns.Length;
}

System.Console.Write("Введите число: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = Num(a);
System.Console.WriteLine(result);
