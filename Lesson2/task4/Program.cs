﻿int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];
while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);

max = array[0];
for(int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach(int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);