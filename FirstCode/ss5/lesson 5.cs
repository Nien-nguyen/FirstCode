using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FirstCode.ss5
{
    internal class lesson_5
    {
        static void bangcuuchuong()
        {
            for (int i = 1; i <= 16; i++)
            {
                Console.WriteLine($"Bang cuu chuong {i}");
                for (int j = 1; j<=10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        static void kimtuthapvietnam()
        {
            for (int i =1; i <= 10; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write($"nyen ");
                }
                Console.WriteLine();
            }
        }

        static void gamedoanso()
        {
            Console.WriteLine("Game doan so co 5 lan doan trong khoang tu 1 den 10");
            Random rnd = new Random();
            int comnum = rnd.Next(1, 10) + 1;
            for (int i=1; i<=5; i++)
            {
                Console.WriteLine($"Ban con {5 - i + 1} lan doan");
                Console.Write("So ban doan la: ");
                int numdoan = int.Parse(Console.ReadLine());
                if (numdoan == comnum)
                {
                    Console.WriteLine("Ban doan trung roi hay qua di");
                    break;
                }
                else if (numdoan >= comnum)
                {
                    Console.WriteLine("So ban doan lon hon roi ban oi");
                }
                else
                {
                    Console.WriteLine("So ban doan nho hon roi ban oi");
                }
                Console.WriteLine();
            }
        }

        //BAI TAP TREN LOP
        //Write a program to read 10 numbers and find their average and sum
        static void bai1()
        {
            int num=0;
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
                num +=i;
            }
            Console.WriteLine($"Sum = {num}");
        }
        //Write a program to display a pattern like triang;es with a number
        static void bai2()
        {
            for (int i = 1; i <= 4;i++) 
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int count = 1;
            for (int i =1; i <=5; i++)
            {
                for (int j=1; j<i; j++)
                {
                    Console.Write($"{count} ");
                    count++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int dem = 1;
            int space = 5;
            for (int i =1; i<=5; i++)
            {
                for (int t = 1; t <= space; t++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{dem} ");
                    dem++;
                }
                space--;
                Console.WriteLine();
            }
        }

        //Write a program to display the n terms of harmonic series and their sum. The harmonic series is 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
        static void bai3()
        {
            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            float sum = 0;
            for (int i = 1; i <=n; i++)
            {
                if (i == n)
                {
                    Console.Write($"1/{i}");
                    break;
                }

                Console.Write($"1/{i} + ");
                sum = sum + (float)1 / i;
            }
            Console.WriteLine($"= {sum}");
        }

        //Write a program to find the perfect numbers within a given number range
        static void bai4()
        {
            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            int sum_uoc = 0;
            int sohoanhao = 0;
            for (int i=1; i<=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (j == i)
                    {
                        break;
                    }
                    else if (i % j == 0)
                    {
                        sum_uoc = sum_uoc + j;
                    }
                }
                if (sum_uoc == i)
                {
                    Console.WriteLine($"{i} la so hoan hao");
                }
                sum_uoc = 0;
            }
            
            
        }

        //Write a program to determine whether a given number is prime or not
        static void bai5()
        {
            Console.Write("Ban muon kiem tra so nguyen to trong khoang n?: ");
            int n = int.Parse(Console.ReadLine());
            int sum_uoc = 0;
            int songuyento = 0;
            for (int k = 1; k <= n; k++)
            {
                for (int i = 1; i <= k; i++)
                {
                    if (k % i == 0)
                    {
                        sum_uoc = sum_uoc + i;
                    }
                }
                if (sum_uoc == 1 + k)
                {
                    Console.WriteLine($"{k} la so nguyen to");
                }
                sum_uoc = 0;
            }
        }
        public static void Mainn(string[] args)
        {
            //bangcuuchuong();
            //kimtuthapvietnam();
            //gamedoanso();
            bai5();
        }
    }
}
