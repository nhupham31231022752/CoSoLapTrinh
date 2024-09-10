
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

internal class Program
{
    static void Main(string[] args)
    {

        //printPrimeNumberUnderN(100);
        printFirstNprimeNumber(n:100);

    }

    /// <summary>
    /// n!= 1*2*3*...*n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static long factorial(int n)
    {
        long f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        return f;
    }
    static long factorial_recursion(int n)
    {
        if (n == 0) return 1;
        return n * factorial_recursion(n - 1);
    }

    static int max(int a, params int[] args)
    {
        if (args.Length == 0)
            return a;

        int m = args[0];
        foreach (int i in args)
        {
            if (i > m)
                m = i;
        }
        return Math.Max(a, m);
    }

    static bool isPrime(int number)
    {
        for (int i = 2; i <= number / 2; i++)
            if (number % i == 0)
                return false;
        return true;
    }
    //Write a C# function to print 
    //    all prime numbers that less than a number(enter prompt keyboard).
    static void printPrimeNumberUnderN(int n)
    {
        for(int i = 1;i<=n;i++)
            if(isPrime(i))
                Console.WriteLine(i);
    }
    //the first N prime numbers
    static void printFirstNprimeNumber(int n)
    {
        int count = 0;
        int number = 1;
        while (count <= n)
        {
            if (isPrime(number))
            {
                Console.WriteLine($"{count}: {number}");
                count++;
            }
            number++;
        }
    }
    
}