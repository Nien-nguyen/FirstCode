using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss8
{
    internal class lesson_8
    {
        //input a string and print it
        static void bai1()
        {
            Console.Write("input a string: ");
            string s = Console.ReadLine();
            Console.WriteLine($"you input: {s}");

        }
        //to find the length of a string without using a library function
        static void bai2()
        {
            Console.Write("nhap cau: ");
            string sen = Console.ReadLine();
            int length = 0;
            foreach (char c in sen)
            {
                length++;

            }
            Console.WriteLine($"Do dai cua cau la: {length}");
   
        }
        // to separate individual characters from a string.
        static void bai3()
        {
            Console.Write("nhap cau: ");
            string sen = Console.ReadLine();
            foreach (char c in sen)
            {
                Console.WriteLine(c);
            }
        }
        // to print individual characters of the string in reverse order.
        static void bai4()
        {
            Console.Write("nhap cau: ");
            string cau = Console.ReadLine();
            int length = cau.Length;
            for (int i = length-1; i >=0; i--)
            {
                Console.Write(cau[i]);
            }
        }
        // to count the total number of words in a string.
        static void bai5()
        {
            Console.Write("nhao cau: ");
            string cau = Console.ReadLine();
            int sochu = 0;
            for (int i = 0; i<cau.Length; i++)
            {
                if (cau[i] == ' ')
                {
                    continue;
                }
                else sochu++;
            }
            Console.WriteLine($"So chu trong cau la: {sochu}");

        }
        public static void Mainn(string[] args)
        {
            bai5();
        }
    }
}
