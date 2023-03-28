// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] Array(string[] array, int value, int length = 0)
{
    string[] arrTemp = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (arrTemp.Length > 0 && j < arrTemp.Length)
            {
                arrTemp[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && arrTemp.Length <= 0) return Array(array, value, length);
    return arrTemp;
}

string EmptyArray(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()?? String.Empty;
}

string[] FillArray(int lenght)
{
    string[] arr = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = EmptyArray($"Введите {i+1} элемент массива");
    }
    return arr;
}

int lenght = Convert.ToInt32(EmptyArray("Введите длину массива"));

int value = Convert.ToInt32(EmptyArray("Введите количество символов"));

string[] arr = FillArray(lenght);

Console.WriteLine($"({string.Join(", ", arr)})");
Console.Write($"({string.Join(", ",Array(arr, value))})");
