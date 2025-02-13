using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de términos de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());
        PrintFibonacciPrimes(n);
    }

    static void PrintFibonacciPrimes(int n)
    {
        int a = 0, b = 1, temp;
        for (int i = 0; i < n; i++)
        {
            if (IsPrime(a))
            {
                Console.Write(a + " ");
            }
            temp = a + b;
            a = b;
            b = temp;
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
