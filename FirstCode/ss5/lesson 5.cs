using System;
using System.Collections.Generic;
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

        public static void Main(string[] args)
        {
            //bangcuuchuong();
            //kimtuthapvietnam();
            //gamedoanso();
            bai2();
        }
    }
}
