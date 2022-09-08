// принять на входь 2 числа (a и b) и выдать число а, возведенное в натуральную степеь  b

Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите  нужную степень");
double b = Convert.ToDouble(Console.ReadLine());


double FindPower(double x, double y)
{

    double result = 0;
    y = Math.Round(y);

    if (y > 0)
    {
        result = Math.Pow(x, y);
    }
    else
    {
        y = y * -1;
        result = Math.Pow(x, y);
    }
    return result;
}

double power = FindPower(a, b);
Console.WriteLine(power);