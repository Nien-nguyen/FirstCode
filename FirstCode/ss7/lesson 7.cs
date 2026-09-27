using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstCode.ss7
{
    internal class lesson_7
    {
        static void nhapmangngaunhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 11);
            }
        }

        static void inmang(int[] a)
        {
            foreach (int v in a)
            {
                Console.Write($"{v} ");
            }
        }
        //static void Main(string[] args)
        //{
        //    int[] a = new int[5];
        //    nhapmangngaunhien(a);
        //    foreach (int v in a)
        //    {
        //        Console.Write($"{v} ");
        //    }
        //}

        //1. to calculate the average value of array elements.
        static int trungbinh(int[] a)
        {
            int sum = 0;
            foreach(int v in a)
            {
                sum += v;
            }
            return sum / a.Length;
        }
        static void Bai1()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapmangngaunhien(a);
            inmang(a);
            Console.WriteLine($"\nTrung binh cong cua mang random {n} phan tu la {trungbinh(a)}");
        }
        //2. to test if an array contains a specific value.
        static bool timkiem(int[] a, int x)
        {
            foreach (int v in a)
            {
                if (a[v] == x)
                    return true;
                else
                    return false;
            }
            return false;
        }
        static void Bai2()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int x = 67;
            inmang(a);
            Console.WriteLine($"Trong mang {(timkiem(a, x) ? "co chua 18" : "khong chua 18")}");
        }
        //3. to find the index of an array element.
        static int kiemthutu(int[] a, int x)
        {
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }
        static void Bai3()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            int x = 7;
            Console.WriteLine($"Phan tu {x} nam o vi tri thu {kiemthutu(a, x)}");
        }
        //4. to remove a specific element from an array.
        static int[] loaibothanhphan(int[] a, int x)
        {
            int count = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] == x)
                {
                    if (i == a.Length - 1)
                    {
                        a[i] = 0;
                    }
                    else
                    {
                        count++;
                        a[i] = a[i + 1];
                        for (int j = i + 2; j < a.Length - 2; j++)
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
                else continue;
            }
            int[] a_new = new int[a.Length - count];
            foreach(int v in a_new)
            {
                a_new[v] = a[v];
            }
            return a_new;
        }
        static void Bai4()
        {
            Console.Write("Nhap so phan tu: ");
            int b = int.Parse(Console.ReadLine());
            int[] a = new int[b];
            nhapmangngaunhien(a);
            inmang(a);
            Console.Write("Chon phan tu ban muon bo: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Mang moi la: ");
            foreach (int v in loaibothanhphan(a,x))
            {
                Console.Write($"{v} ");
            }
        }
        //5. to find the maximum and minimum value of an array.
        //6. to reverse an array of integer values.
        //7. to find duplicate values in an array of values.
        //8. to remove duplicate elements from an array

        static void MainN(string[] args)
        {
            Bai4();
        }
    }
}
