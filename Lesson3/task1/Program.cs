double CalculateFormula(int a, int b, int c, int d)
{
    double nomenator = a * b;
    int denomenator = a + b;
    double result = nomenator / denomenator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);