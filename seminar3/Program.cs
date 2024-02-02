int[] array = { 1, 34, 19, 3 };
int number = 8;
bool result = false;
for (int i = 0; i < array.Length; i = i + 1)
{
    if (array[i] == number)
        result = true;
}
if (result == true)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}