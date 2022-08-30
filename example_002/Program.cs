// Факториал числа

// Console.Clear();

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// Console.WriteLine(FactorialFor(10));

// int FactorialRec(int n)
// {
//     if (n == 1 || n == 0) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialRec(0));

// Вычислить a в степени n

Console.Clear();

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}
Console.WriteLine(PowerFor(3, 5));

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return a * PowerRec(a, n-1);
}
Console.WriteLine(PowerRec(3,5));

int PowerRecMath(int a, int n)
{
     if (n == 0) return 1;
     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
     else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(3,5));