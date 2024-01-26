//int n = 10;
int[] array = { 3, 43, 25, 1, 23, 11, 17, 7, 49, 5 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    //Console.Write($"{array[i]} ");
    System.Console.Write(array[i]);
    System.Console.Write(' ');
    i = i + 1;
}