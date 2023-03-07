// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию строки: ");
int positionrow = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию столбца: ");
int positioncolumn = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

if (positionrow <= 0  | positionrow > matrix.GetLength(0) -1  | positioncolumn <= 0  | positioncolumn > matrix.GetLength(1) -1 )//(positionrow<1 || positioncolumn<1)
//Console.WriteLine("Позиции не могут быть отрицательными");
//else if (positionrow>row && positioncolumn>column)
Console.WriteLine("Такого элемента нет");
 else
 {
Console.WriteLine("Значение элемента массива = {0}", matrix[positionrow-1, positioncolumn-1]);
 }