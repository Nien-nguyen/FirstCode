using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FirstCode.ss8
{
    internal class BAI_TAP_STRINGS
    {
        static string inputchuoi()
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            return str;
        }
        static void tachtungchu(string str)
        {
            Console.Write("The characters of the string are: ");
            foreach(char c in str)
            {
                Console.Write(c + " ");
            }
        }
        static int dodaichuoi(string str)
        {
            int count = 0;
            foreach(char c in str)
            {
                count++;
            }
            return count;
        }
        static void indaonguoc(string str)
        {
            Console.WriteLine("The string in reverse order is: ");
            int length = dodaichuoi(str);
            for (int i = length-1; i>=0; i--)
            {
                Console.Write(str[i]);
            }
        }
        static int demchu(string str)
        {
            int count = 0;
            for (int i = 0; i<dodaichuoi(str); i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static void sosanhhaichuoi()
        {
            Console.Write("Nhap chuoi dau tien: ");
            string str1 = Console.ReadLine();
            Console.Write("Nhap chuoi thu hai: ");
            string str2 = Console.ReadLine();
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("Hai chuoi co do dai bang nhau");
                if (demchu(str1) == demchu(str2))
                {
                    Console.WriteLine("Hai chuoi co so chu cai bang nhau");
                    bool same = true;
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i] == str2[i]) continue;
                        else same = false;
                    }
                    if (same) Console.WriteLine("Hai chuoi giong het nhau");
                    else Console.WriteLine("Hai chuoi khac nhau noi dung");
                }
                Console.WriteLine("Hai chuoi khac nhau ve so chu cai");

            }
            else Console.WriteLine("Hai chuoi khac nhau");
        }
        static void dem(string str)
        {
            int chu = 0;
            int so = 0;
            int kitu = 0;
            foreach (char c in str)
                if (char.IsLetter(c)) chu++;
                else if (char.IsDigit(c)) so++;
                else kitu++;
            Console.WriteLine($"So chu cai {chu}");
            Console.WriteLine($"So chu so {so}");
            Console.WriteLine($"So ki tu dac biet {kitu}");
        }
        static void demnguyenam(string str)
        {
            int nguyenam = 0;
            int phuam = 0;
            foreach (char c in str)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0) nguyenam++;
                else if (char.IsLetter(c)) phuam++;
            }
            Console.WriteLine($"So nguyen am: {nguyenam}");
            Console.WriteLine($"So phu am: {phuam}");
        }
        static bool checksub(string str, string sub)
        {
            if (str.IndexOf(sub) >= 0) return true;
            else return false;
        }
        static void vitrisub(string str, string sub)
        {
            int start = str.IndexOf(sub);
            int end = start + sub.Length - 1;
            if (checksub(str, sub))
            {
                Console.WriteLine($"Chuoi con bat dau o vi tri {start} va ket thuc tai vi tri {end}");

            }
        }
        static int demsub(string str, string sub)
        {
            int count = 0;
            while (checksub(str,sub))
            {
                    count++;
                    str = str.Substring(str.IndexOf(sub)+sub.Length);
                
            }
            return count;
        }
        static string addsub(string str1, string sub, string str2)
        {
            string newstr = str1.Substring(0, str1.IndexOf(str2)) + sub + str1.Substring(str1.IndexOf(str2));
            return newstr;
        }
        public static void Main(string[] args)
        {
            string str = inputchuoi();
            Console.WriteLine($"Chuoi vua nhap: {str}");
            tachtungchu(str);
            Console.WriteLine($"\nThe length of the string is: {dodaichuoi(str)}");
            indaonguoc(str);
            Console.Write($"\nThe total number of characters in the string is: {demchu(str)}");
            sosanhhaichuoi();
            Console.WriteLine();
            dem(str);
            Console.WriteLine();
            demnguyenam(str);
            Console.WriteLine();
            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();
            Console.WriteLine($"{(checksub(str, sub) ? "Chuoi con co trong chuoi chinh" : "Chuoi con khong co trong chuoi chinh")}");
            vitrisub(str, sub);
            Console.WriteLine();
            Console.WriteLine($"So lan xuat hien cua chuoi con trong chuoi chinh la: {demsub(str, sub)}");
            Console.Write("Nhap chuoi can chen: ");
            string sub2 = Console.ReadLine();
            Console.Write("Nhap chuoi can chen vao truoc: ");
            string str2 = Console.ReadLine();
            Console.WriteLine($"Chuoi moi sau khi chen: {addsub(str, sub2, str2)}");
        }
    }
}
