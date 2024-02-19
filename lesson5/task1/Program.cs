//Вычисить факториал от натурального числа N
int Fact(int n)
{
    if (n == 1)
    {
        System.Console.WriteLine($"Stop: {n}");
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n - 1);
}
System.Console.WriteLine(Fact(5));

//F11 Шаг с заходом
//F10 Шаг с обходом