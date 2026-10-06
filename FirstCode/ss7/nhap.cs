using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss7
{
    internal class nhap
    {
        static void Mainn(String[] args)
        {
            Console.Write("nhap: ");
            string a = Console.ReadLine();
            while (!int.TryParse(a, out int num))
            {
                Console.WriteLine("ko dung");
                Console.Write("Vui long nhap lai: ");
                a = Console.ReadLine();
            }
            Console.WriteLine(a);
        }
    }
}
