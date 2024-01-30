int n = 96;

if (n >= 10 & n <= 99)
{
    int n1 = (n % 10);
    int n2 = (n / 10); 

    if (n1 > n2)
    {
        System.Console.WriteLine(n1);
    }
    else
    {
        System.Console.WriteLine(n2);
    }
}