int[] arr = { 2, 6, 9, 1, 8 };
int[] reverse = Enumerable.Reverse(arr).ToArray();
System.Console.WriteLine(String.Join(' ', reverse));

// int[] numbers = { 1, 3, 5, 6, 7, 8 };
// int temp;
// Console.Write("Исходный массив: ");
// foreach (int number in numbers)
// {
//     Console.Write(number + " ");
// }
// for (int i = 0; i < numbers.Length / 2; i++)
// {
//     temp = numbers[i];
//     numbers[i] = numbers[numbers.Length - 1 - i];
//     numbers[numbers.Length - 1 - i] = temp;
// }
// Console.Write("\nПеревернутый массив: ");
// foreach (int number in numbers)
// {
//     Console.Write(number + " ");
// }