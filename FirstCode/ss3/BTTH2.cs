using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss3
{
    internal class BTTH_
    {
        private static void Main4(string[] args)
        {
            //EXERCISE 1
            Console.Write("Chuyen doi do C sang do F vaf Kelvin: ");
            float do_c = float.Parse(Console.ReadLine());
            int do_f = (int)((do_c * 18) / 10 + 32);
            float do_k = do_c + 273;
            Console.WriteLine($"{do_c} C = {do_f} F = {do_k} K");
            Console.ReadKey();

            //EXERCISE 2
            Console.Write("Nhap ban kinh hinh cau: ");
            int r = int.Parse(Console.ReadLine());
            float surface = 4 * (float)Math.PI * r * r;
            float volume = (4f / 3f) * (float)Math.PI * r * r * r;
            Console.WriteLine($"Dien tich hinh cau: {surface}");
            Console.ReadKey();
            Console.WriteLine($"The tich hinh cau: {volume}");
            Console.ReadKey();

            //EXERCISE 3
            Console.Write("Nhap so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            float div = (float)a/ (float)b;
            int mod = a % b;
            Console.WriteLine($"{a} + {b} = {add} \n " +
                $"{a} - {b} = {sub} \n" +
                $"{a} * {b} = {mul} \n" +
                $"{a} / {b} = {div} \n" +
                $"{a} mod {b} = {mod}"); 
            Console.ReadKey();
        }
    }
}
