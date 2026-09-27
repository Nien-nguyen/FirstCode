using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss7
{
    internal class BAITAP__6
    {
        /*▸Create a random integer values array, then create functions that:
        1.to calculate the average value of array elements.
        2.to test if an array contains a specific value.
        3.to find the index of an array element.
        4.to remove a specific element from an array.
        5.to find the maximum and minimum value of an array.
        6.to reverse an array of integer values.
        7.to find duplicate values in an array of values.
        8.to remove duplicate elements from an array.*/

        static int[] chuoirandom(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = rnd.Next(1, 10);
            }
            return a;
        }
        
        static void inchuoirnd(int[] a)
        {
            foreach (int v in a)
            {
                Console.Write($"{v} ");
            }
        }

        static double average(int[] a)
        {
            double sum = 0;
            for (int i = 0; i<a.Length; i++)
            {
                sum += a[i];
            }
            return sum / a.Length;
        }

        static bool check(int[] a, int x)
        {
            for (int i =0; i<a.Length; i++)
            {
                if (a[i] == x)
                {
                    return true;
                }
                else continue;
            }
            return false;
        }

        static int findindex(int[] a, int x)
        {
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
                else continue;
            }
            return -1;
        }

        static int[] remove(int[] a, int x)
        {
            int count = 0;
            int[] newchuoi = new int[a.Length];
            int b = 0;
            for (int i =0; i<a.Length; i++)
            {
                if (a[i] != x)
                {
                    newchuoi[b] = a[i];
                    b++;
                }
                else
                {
                    count++;
                    continue;
                }
            }
            int[] result = new int[a.Length - count];
            for (int i =0; i<result.Length; i++)
            {
                result[i] = newchuoi[i];
            }
            return result;
        }
        static void inchuoi(int[] a)
        {
            foreach( int v in a)
            {
                Console.Write($"{v} ");
            }
        }

        static int max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] >= max)
                {
                    max = a[i];
                }
                else continue;
            }
            return max;
        }

        static int min(int[] a)
        {
            int min = a[0];
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] <= min)
                {
                    min = a[i];
                }
                else continue;
            }
            return min;
        }

        static void Bai4()
        {
            Console.Write("Nhap so luong phan tu mong muon: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            chuoirandom(a);
            inchuoirnd(a);
            Console.Write("\nNhap phan tu muon xoa: ");
            int x = int.Parse(Console.ReadLine());
            inchuoi(remove(a, x));
        }

        static void timminmax()
        {
            Console.Write("Nhap so luong phan tu mong muon: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            chuoirandom(a);
            inchuoirnd(a);
            Console.WriteLine($"\nPhan tu Max la: {max(a)}, Min la: {min(a)}");
        }

        static int[] reversed(int[] a)
        {
            int z = a.Length - 1;
            int[] newchuoi = new int[a.Length];
            for (int i =0; i<a.Length; i++)
            {
                newchuoi[z] = a[i];
                z--;
            }
            return newchuoi;
        }
        static void Bai6()
        {
            Console.Write("Nhap so luong phan tu mong muon: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            chuoirandom(a);
            inchuoirnd(a);
            Console.WriteLine("\nChuoi da duoc dao nguoc: ");
            inchuoi(reversed(a));
        }

        static int[] duplicate(int[] a)
        {
            int[] dup = new int[a.Length / 2];
            int n = 0;
            for (int i = 0; i<a.Length; i++)
            {
                for (int j = i+1; j<a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        dup[n] = a[i];
                        n++;
                        a = remove(a, a[j]);
                        i--;
                        break;
                    }
                    else continue;
                }
                
            }
            int[] result = new int[n];
            for (int i = 0; i<n; i++)
            {
                result[i] = dup[i];
            }
            return result;
        }
        static void Bai7()
        {
            Console.Write("Nhap so luong phan tu mong muon: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            chuoirandom(a);
            inchuoirnd(a);
            Console.WriteLine("\nCac phan tu duoc lap lai la:");
            inchuoi(duplicate(a));
        }

        static int[] removedup(int[] a)
        {
            int[] chuoi_Dup = duplicate(a);
            for (int i = a.Length-1; i>=0; i--)
            {
                for (int j =0; j<chuoi_Dup.Length; j++)
                {
                    if (a[i] == chuoi_Dup[j])
                    {a = remove(a, a[i]);
                        if (i >= a.Length)
                        {
                            i = a.Length;
                        }
                        break;
                    }
                }
            }
            return a;
        }
        static void Bai8()
        {
            Console.Write("Nhap so luong phan tu mong muon: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            chuoirandom(a);
            inchuoirnd(a);
            Console.WriteLine("\nCac phan tu duoc lap lai la:");
            inchuoi(duplicate(a));
            Console.WriteLine("\nChuoi sau khi bo cac phan tu lap lai:");
            inchuoi(removedup(a));
        }

        /*▸Create a C# program that
        -requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        -Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.*/
        static void nhapsosapxep()
        {
            Console.WriteLine("Nhap 10 so nguyen");
            int[] a = new int[10];
            for (int i  = 0; i<10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nChuoi sau sap xep theo thu tu tu be den lon");
            inchuoi(sapxep(a));
        }
        static int[] sapxep(int[] a)
        {
            int n = a.Length;
            for(int i=0; i<n-1; i++)
            {
                for (int j = 0; j<n-i-1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

        static void kiemtutrongcau()
        {
            Console.Write("Nhap mot cau gi do: ");
            string sentence = Console.ReadLine();
            string[] a = sentence.Split(" ");
            Console.Write("Nhap tu muon tim kiem: ");
            string x = Console.ReadLine();
            Console.WriteLine($"{x} {(cotrongcau(a, x) ? "co trong cau" : "khong co trong cau")}");
            if (thututrongcau(a, x) == -1)
                Console.WriteLine();
            else
                Console.WriteLine($"{x} nam o vi tri thu {thututrongcau(a, x)+1}");
        }
        static bool cotrongcau(string[] a, string x)
        {
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] == x)
                {
                    return true;
                }
                else continue;
            }
            return false;
        }
        static int thututrongcau(string[] a, string x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }

        /*▸Create a program with following functions
        -Create an integer matrix N x M (N,M was prompted from user) randomly.
        -Print the matrix.
        -Print the ith row/column. (i was prompted from user)
        -Find the max value of the matrix.
        -Find the min value of ith row/col of the matrix.
        -Transpose the matrix.
        -Print the main/secondary diagonal values of the matrix.(square maxtrix)*/

        static void matran()
        {
            Console.Write("Nhap so hang: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ma tran {n}x{m}:\n");
            int[] rnd = random(n, m);
            rndmatrix(rnd,n,m);
            Console.WriteLine();
            //Console.Write("Ban muon in hang so may: ");
            //int x = int.Parse(Console.ReadLine());
            //inhang(x, n, m, rnd);
            //Console.WriteLine($"\nPhan tu lon nhat trong hang {x} la {max_hang(rnd,n,m,x)}");
            //Console.Write("\nBan muon in cot so may: ");
            //int y = int.Parse(Console.ReadLine());
            //incot(y, n, m, rnd);
            //Console.WriteLine($"\nPhan tu lon nhat trong cot {y} la {max_cot(rnd, n, m, y)}");
            //Console.WriteLine($"\nPhan tu lon nhat trong ma tran la: {max_value(rnd)}");
            Console.WriteLine("Ma tran chuyen vi");
            chuyenvimatrix(n,m,matrix(n,m,rnd));
            Console.WriteLine($"Duong cheo chinh la:");
            duongcheochinh(matrix(n, m, rnd), n, m);
            Console.WriteLine("\nDuong cheo phu la:");
            duongcheophu(matrix(n, m, rnd), n, m);

        }
        static int[] random(int n, int m)
        {
            Random r = new Random();
            int[] rnd = new int[n * m];
            for (int i = 0; i<rnd.Length; i++)
            {
                rnd[i] = r.Next(1, 10);
            }
            return rnd;
        }

        static void rndmatrix(int[] rnd, int n, int m)
        {
            int x = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write($"{rnd[x]} ");
                    x++;
                }
                Console.WriteLine();
            }
        }

        static void inhang(int x, int n, int m, int[] rnd)
        {
            int a = 0;
            for (int i = 1; i<=n; i++)
            {
                for (int j = 1; j<=m; j++)
                {
                    if (i == x)
                    {
                        Console.Write($"{rnd[a]} ");
                        a++;
                    }
                    else a++;
                }
            }
        }

        static void incot(int x, int n, int m, int[] rnd)
        {
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (j == x)
                    {
                        Console.Write($"{rnd[a]} ");
                        a++;
                    }
                    else a++;
                }
            }
        }

        static int max_value(int[] rnd)
        {
            int max = rnd[0];
            for (int i = 0; i<rnd.Length; i++)
            {
                if (max <= rnd[i])
                {
                    max = rnd[i];
                }
            }
            return max;
        }

        static int max_cot(int[] rnd, int n, int m, int y)
        {
            int max = 0;
            int a = 0;
            for (int i = 1; i<=n; i++)
            {
                for (int j = 1; j<=m; j++)
                {
                    if (y == j)
                    {
                        if (rnd[a] >= max)
                        {
                            max = rnd[a];
                            a++;
                            continue;
                        }
                    }
                    a++;
                }
            }
            return max;
        }

        static int max_hang(int[] rnd, int n, int m, int x)
        {
            int max = 0;
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (x == i)
                    {
                        if (rnd[a] >= max)
                        {
                            max = rnd[a];
                            a++;
                            continue;
                        }
                    }
                    a++;
                }
            }
            return max;
        }

        static int[,] matrix(int n, int m, int[] rnd)
        {
            int[,] matrix = new int[n, m];
            int a = 0;
            for (int i = 0; i< n; i++)
            {
                for (int j =0; j<m; j++)
                {
                    matrix[i, j] = rnd[a]; a++;
                }
            }
            return matrix;
        }
        static void chuyenvimatrix(int n, int m, int[,] matrix)
        {
            int[,] chuyenvi = new int[m, n];
            for (int j = 0; j<m; j++)
            {
                for (int i = 0; i<n; i++)
                {
                    chuyenvi[j,i] = matrix[i, j];
                    Console.Write($"{chuyenvi[j, i]} ");
                }
                Console.WriteLine();
            }
        }

        static void duongcheochinh(int[,] matrix, int n, int m)
        {
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<m; j++)
                {
                    if (i==j)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }
        }

        static void duongcheophu(int[,] matrix, int n, int m)
        {
            m--;
            for (int i = 0; i<n; i++)
            {
                Console.Write($"{matrix[m, i]} ");
                m--;
            }
        }
        public static void Main(string[] args)
        {
            matran();
        }
    }
}
