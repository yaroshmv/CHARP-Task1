//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

    int[] array = { 1, 2, 5, 0, 10, 34 };
    Console.WriteLine("\t Исходный массив: ");
    Console.WriteLine();
    PrintArray(array);

    Console.WriteLine();

    Console.WriteLine("\t Реверс массива: ");
    Console.WriteLine();
    PrintArrayReverse(array, array.Length - 1);
    Console.WriteLine();


static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }


}

static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }
}
