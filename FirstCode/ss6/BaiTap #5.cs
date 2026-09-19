using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss6
{
    internal class BaiTap__5
    {
        //Bai 1: Tinh tong hai so nguyen
        static int tinhtong(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Bai1()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong hai so la: {tinhtong(a, b)}");

        }
        //Bai 2: Kiem tra so chan le
        static bool kiemtrachan(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }
        static void Bai2()
        {
            Console.Write("Nhap so n de kiem tra chan le: ");
            int n = int.Parse(Console.ReadLine());
            if (kiemtrachan(n))
            {
                Console.WriteLine($"{n} la so chan");
            }
            else
            {
                Console.WriteLine($"{n} la so le");
            }
        }

        //Bai 3: Tim so lon nhat trong 3 so
        static int timmax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            else if (c > max) max = c;
            return max;
        }
        static void Bai3()
        {
            Console.Write("Nhap so thuw nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat trong 3 so la {timmax(a, b, c)}");
        }

        //Bai 4: Tinh giai thua cua mot so nguyen duong
        static long tinhgiaithua(int n)
        {
            long giaithua = 1;
            for (int i =1; i<=n; i++)
            {
                giaithua *= i;
                
            }
            if (n == 0) return 1;
            else return giaithua;
        }
        static void Bai4()
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giai thua cua {n}! la {tinhgiaithua(n)}");

        }

        //Bai 5: Dao nguoc chuoi ky tu
        static string daonguocchuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Bai5()
        {
            Console.Write("Nhap chuoi cac ky tu: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Chuoi bi dao nguoc la: {daonguocchuoi(input)}");
        }

        //Bai 6: Kiem tra so nguyen to
        static bool kiemtranguyento(int n)
        {
            int sumuoc = 0;
            for (int i = 1; i<=n; i++)
            {
                if (n%i==0)
                {
                    sumuoc += i;
                }
            }
            if (sumuoc == n + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Bai6()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} {kiemtranguyento(n)}");

        }

        //Bai 7: in day fibonacci
        static void infibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i =1; i <=n; i++)
            {
                Console.Write($"{a} ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
        static void Bai7()
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            infibonacci(n);
        }

        //Bai 8: 
        static int demnguyenam(string s)
        {
            s = s.ToLower();
            int count = 0;
            foreach (char c in s)
            {
                if (c=='a' || c=='e' || c=='i' || c=='o'|| c=='u')
                {
                    count++;
                }
            }
            return count;
        }
        static void Bai8()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"So nguyen am trong chuoi la {demnguyenam(s)}");

        }

        //Bai 9:
        static double tinhluythua(double x, int n)
        {
            double result = 1;
            if (n == 0) return 1;
            for (int i =1; i<=n; i++)
            {
                result *= x;
            }
            return result;
        }
        static void Bai9()
        {
            Console.Write("Nhap so x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}^{n} = {tinhluythua(x, n)}");

        }

        //Bai 10: tinh diem trung binh cua mang 
        static double tinhtrungbinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        static void Bai10()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i =0; i <n;i++)
            {
                Console.Write($"Nhap phan tu thu {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Trung binh cong cua mang la: {tinhtrungbinh(arr)}");

        }

        //Bai 11: kiem tra chuoi doi xung
        static bool kiemtradoixung(string s)
        {
            s = s.ToLower();
            char[] chararray = s.ToCharArray();
            Array.Reverse(chararray);
            string reversed = new string(chararray);
            if (s == reversed) return true;
            else return false;
        }
        static void Bai11()
        {
            Console.Write("Nhap chuoi de kiem tra xem: ");
            string s = Console.ReadLine();
            Console.WriteLine(kiemtradoixung(s));

        }

        //Bai 12: Chuyen doi doC sang doF
        static double celciustofahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static void Bai12()
        {
            Console.Write("Nhap nhiet do C: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"{c} do c = {celciustofahrenheit(c)} do f");

        }

        //Bai 13: timsonhonhattrongmang
        static int timmin(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int min = arr[0];
            for(int i =0; i<arr.Length;i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        static void Bai13()
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i =0; i<n; i++)
            {
                Console.Write($"Nhap so thu {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Gia tri nho nhat trong mang la {timmin(arr)}");
        }

        //Bai 14: Tinh tong cac chu so cua mot so nguyen
        static int tongcacchuso(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n>0)
            {
                int digit = n % 10;
                sum = sum + n % 10;
                n = n / 10;
            }
            return sum;
        }
        static void Bai14()
        {
            Console.Write("Nhap mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong cac chu so cua {n} la {tongcacchuso(n)}");
        }

        //Bai 15: sap xep mang tang dan
        static int[] sapxepmang(int[] arr)
        {
            if (arr == null || arr.Length == 0) return new int[0];
            for(int i =0; i<arr.Length -1; i++)
            {
                for (int j = i+1; j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static void Bai15()
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i<n; i++)
            {
                Console.Write($"Nhap so thu {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Mang da sap xep theo thu tu tang dan la {string.Join(", ",sapxepmang(arr))}");
        }

        //Bai 16: xoa ky tu trung lap
        static string xoatrunglap(string s)
        {
            if (s == null || s.Length == 0) return "Khong hop le";
            char[] chuoi = s.ToCharArray();
            char a = chuoi[0];
            for (int i =0; i<chuoi.Length; i++)
            {
                for (int j = 0; j <chuoi.Length; j++)
                {
                    if (j==i)
                    {
                        continue;
                    }
                    else if (chuoi[i] != chuoi[j])
                    {
                        continue;
                    }
                    else
                    {
                        string str = new string(chuoi);
                        str = str.Remove(j, 1);
                        chuoi = str.ToCharArray();
                        
                    }
                }
            }
            string result = new string(chuoi);
            return result;
        }
        static void Bai16()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuoi da xoa ky tu lap: {xoatrunglap(s)}");
        }

        //Bai 17: tim uoc chung lon nhat
        static int ucln(int a, int b)
        {
            int c = 0;
            int max = Math.Max(a, b);
            for (int i = 1; i<=max; i++)
            {
                if (a%i==0 & b%i==0)
                {
                    if (i > c) c = i;
                }
            }
            return c;
        }
        static void Bai17()
        {
            Console.Write("Nhap so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Uoc chung lon nhat giua {a} va {b} la {ucln(a, b)}");

        }

        //Bai 18: chuyen doi he thap phan sang nhi phan
        static string decimaltobinary(int n)
        {
            List<int> result = new List<int>();
            while (n>0)
            {
                result.Add(n % 2);
                n = n / 2;
            }
            result.Reverse();
            string reversed = string.Join("", result);
            return reversed;

        }
        static void Bai18()
        {
            Console.Write("Nhap vao so thap phan: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuoi nhi phan cua {n} la {decimaltobinary(n)}");
        }

        //Bai 19: kiem tra nam nhuan
        static bool kiemtranamnhuan(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    return true;
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            else return false;
        }
        static void Bai19()
        {
            Console.Write("Nhap vao nam kiem tra: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"{year} la nam {(kiemtranamnhuan(year) ? "nhuan" : "khong nhuan")}");
        }

        //Bai 20: dem so tu trong cau
        static int demsotu(string sentence)
        {
            string[] tu = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int num = tu.Length;
            return num;
        }
        static void Bai20()
        {
            Console.Write("Nhap vao mot cau: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Trong cau co {demsotu(sentence)} tu");
        }
        static void Nhap()
        {
            Console.WriteLine(1 / 2);
        }
        public static void Main(string[] args)
        {
            Bai20();
        }
    }
}
