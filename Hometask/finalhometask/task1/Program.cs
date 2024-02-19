//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void PrintRange(int n, int m = 4)
{
    if (m > n)
    {
        System.Console.WriteLine();
        return;
    }
    System.Console.Write($"{m} ");
    PrintRange(n, m + 1);
}
PrintRange(8);
PrintRange(4);