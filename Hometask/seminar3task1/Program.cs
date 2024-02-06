int[] numbers = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
int count = 0;
foreach (int number in numbers)
{
    if (number >= 10 && number <= 90)
        return count++;
}
Console.WriteLine ("Количество элементов массива, значения которых лежат в отрезке от 30 до 60: " + count);