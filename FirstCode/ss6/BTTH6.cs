using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss6
{
    internal class BTTH6
    {
        //1. Write a function to find the maximum of three numbers.
        static int maxofthree(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static void Bai1()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = maxofthree(a, b, c);
            Console.WriteLine($"So lon nhat trong ba so la {max}");
        }

        //2. Write a function to calculate the factorial of a number (a non-negative interger). The function accepts the number as an argument
        static int factorial(int n)
        {
            
            int result=0;
            for (int i =1; i<=n; i++)
            {
                if (i == n) Console.Write($"{i} = ");
                else
                {
                    Console.Write($"{i} * ");
                    result = result * i;
                }
            }
            return result;
        }
        static void Bai2()
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine($"{result}");
        }

        //3. Write a function that takes a number as a parameter and checks whether the number is prime or not.
        static bool checkprime(int n)
        {
            int sumuoc = 0;
            for (int i =1; i<=n; i++)
            {
                if (n%i ==0)
                {
                    sumuoc = sumuoc + i; 
                }
            }
            if (sumuoc == n + 1)
            {
                return true;
            }
            else return false;
        }

        static void Bai3()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            if (checkprime(n)==true)
            {
                Console.WriteLine($"{n} la so nguyen to");
                
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
        }

        //4. write a function to print:
        //a. all prime numbers that less than a given number
        //b. the first n prime numbers
        static void primelessthann(int n)
        {
            for (int i =2; i<n; i++)
            {
                if (checkprime(i))
                {
                    Console.Write($"{i}, ");
                }
            }
            
        }
        static void firstnprime(int n)
        {
            int count = 0;
            int i = 1;
            while (count < n)
            {
                if (checkprime(i))
                {
                    Console.Write($"{i}, ");
                    count++;
                }
                i++;
            }
        }
        static void Bai4()
        {
            Console.Write("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac so nguyen to nho hon {n} la: {primelessthann}");
        }
        private static void Mainn(string[] args)
        {
            Bai4();
        }
    }
}
