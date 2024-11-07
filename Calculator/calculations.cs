using System;
using System.Diagnostics.CodeAnalysis;

class Calculations{

public static int Add(int[] args)
{
    int sum = 0;
    foreach (int num in args)
    {
        sum += num;
    }
    return sum;
}

public static int Substract(int[] args)
{
    int sum = 0;
    foreach (int num in args)
    {
        sum -= num;

    }
    return sum;
}

public static int Multiply(int[] args)
{
    int product = 1;
    foreach (int num in args)
    {
        product *= num;
    }
    return product;
}

public static float Divide(int[] args)
{
    float quotient = 1;
    foreach (int num in args)
    {
        quotient /= num;
    }
    return quotient;
}

}