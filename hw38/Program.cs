// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] FillArrayWithRandomNumbers(int length)
{
int[] array = new int[length];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(0,100);
}
 return array;
 }

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
 {
     if (array[i] > max)
     {
         max = array[i];
     }
     if (array[i] < min)
     {
         min = array[i];
     }
 }
 Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");