using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0, b = 1, i = 0; i < 91; i++)
            {
                // B (kovetkezo fib. szam) = a jelenlegi ketto osszege
                b = a + b;
                // A (elozo fib. szam) = a regi B = ujB - a
                a = b - a;
                Console.WriteLine($"A(z) {i + 1}. Fibonacci szám: {a}");
            }
            Console.ReadLine();
        }
        /*static int fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }*/
    }
}
