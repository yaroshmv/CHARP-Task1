// Task2
int N=4;
if (N>0)
{
    int i=-N;
    while (i<=N)
    {
       // System.Console.Write(i);
       // System.Console.Write(',');
        i+=1;
    }
}
else
{
    int i=N;
    while (i<=-N)
    {
        // System.Console.Write(i);
        // System.Console.Write(',');
        i+=1;
    }
}

// Task3
int a = 782;

int a1 = a / 100;
int a2 = a % 10;

int sum = a1 + a2;
System.Console.WriteLine(sum);