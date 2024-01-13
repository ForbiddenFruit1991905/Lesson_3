/* int n = 5;

int i = 1;
while (i <= n)
{
    Console.Write($"{i*i} ");
    i++;
}

n = 10;
i = 1;
while (i <= n)
{
    Console.Write($"{i*i} ");
    i++;
}

n = 15;
i = 1;
while (i <= n)
{
    Console.Write($"{i*i} ");
    i++;
}  */

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);