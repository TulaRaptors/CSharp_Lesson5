// Написать программу копирования массива

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Копированный массив: ");
int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
PrintArray(newArray);

/*
Console.WriteLine();
int[] copyArray = new int[array.Length];
array.CopyTo(copyArray, 0);
Console.Write("Копированный массив: ");
PrintArray(copyArray);
*/