using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace FirstCode.ss4
{
    internal class lesson_4
    {
        static void Bai_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
        static void Bai_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int y;
            while (true)
            {
                Console.Write("Nhập số y: ");
                y = int.Parse(Console.ReadLine());
                if (y >= -5 && y <= 5)
                { break; }
            }
            int func = y*y + 2*y + 1;
            Console.WriteLine($"Function x = {y}^2 + 2{y} + 1 = {func}");
        }
        static void Bai_3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter the distance (km): ");
            double dis = double.Parse(Console.ReadLine());
            string time;
            TimeSpan result;
            while (true)
            {   Console.Write("Enter time (hours:minutes:seconds): ");
                time = Console.ReadLine();
                if (TimeSpan.TryParseExact(time,"hh\\:mm\\:ss",null,out result))
                {
                    break;
                }
                Console.WriteLine("Again");
            }
            
            double kph = dis / result.TotalHours;
            Console.WriteLine($"The speed is {kph:f2} km/h");
            double miles = dis * 0.621371d;
            double mph = miles / result.TotalHours;
            Console.WriteLine($"The speed is {mph:f2} miles/h");
            Console.ReadKey();
        }
        static void Bai_4()
        {
            
            Console.Write("Enter the radius of a sphere: ");
            double rad = double.Parse(Console.ReadLine());
            double vol = (4d / 3d) * Math.PI * Math.Pow(rad, 3);
            Console.WriteLine($"The volume of the sphere is {vol:f2}");
            Console.ReadKey();
        }
        static void Bai_5() //Giai phuong trinh bac hai
        {
            Console.WriteLine("Cho ptrinh bac 2: \n \t ax^2 + bx + c = 0");
            Console.Write("Enter a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: "); double c = double.Parse(Console.ReadLine());
            double x;
            double x1, x2;
            double delta;
            if (a==0)
            {
                if(b==0)
                {
                    if (c==0)
                    {
                        Console.WriteLine("X can be any number");
                    }
                    else
                    {
                        Console.WriteLine("There is no X");
                    }
                }
                else
                {
                    x = -c / b;
                    Console.WriteLine($"x = {x}");
                }
            }
            else
            {
                delta = b * b - 4d * a * c;
                if (delta<0)
                {
                    Console.WriteLine("There is no X");
                }
                else
                {
                    if (delta==0)
                    {
                        x1 = x2 = -b / (2d * a);
                        Console.WriteLine($"x1 = {x1} \n x2 = {x2}");
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2d * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2d * a);
                        Console.WriteLine($"x1 = {x1} \n x2 = {x2}");
                    }
                }
            }

        }
        static void Main8(string[] args)
        {
            Bai_5();
        }
    }
}
