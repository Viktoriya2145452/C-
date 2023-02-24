// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i =0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}


System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
int[] newArray = newMassive(array);
int i = 0;
int z = array.Length/2+1;
for(int j =0; j < z; j++)
{
arr[j] = array[i]*array[array.Length-1];
i++;
}



System.Console.WriteLine($"[{string.Join(", ", newArray)}]");


