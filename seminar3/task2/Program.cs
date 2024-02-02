const int size = 10;
int[] array = new int[size] { 1, -5, 6, 5, -7, 8, 2, -2, -3, 9 };

for (int i = 0; i < size; i++)
{
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();
for (int i = 0; i < size; i++)
{
    array[i] = -array[i];
}
for (int i = 0; i < size; i++)
{
     System.Console.Write($"{array[i]} ");
}