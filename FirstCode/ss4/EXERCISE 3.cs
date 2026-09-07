using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss4
{
    internal class EXERCISE_3
    {
        static void Bai1()
        {
            Console.WriteLine("Bai 1: Viet chuong trinh giai va bien luan phuong trinh bac 2");
            Console.WriteLine("Cho ptrinh bac 2: \n \t ax^2 + bx + c = 0");
            Console.Write("Enter a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: "); double c = double.Parse(Console.ReadLine());
            double x;
            double x1, x2;
            double delta;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
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
                if (delta < 0)
                {
                    Console.WriteLine("There is no X");
                }
                else
                {
                    if (delta == 0)
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
        static void Bai2()
        {
            Console.WriteLine("\nBai2: Write program to check whether a given number is even or odd");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("This is an even number.");

            }
            else
            { Console.WriteLine("This is an odd number."); }
        }
        static void Bai3()
        {
            Console.WriteLine("\n Bai 3: write program to find the largest of three numbers");
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());
            double[] nums = { num1, num2, num3 };
            double max = nums.Max();
            Console.WriteLine($"The largest number is: {max}");
        }
        static void Bai4() {

            Console.WriteLine("\nBai4: write a program to check whether a triangle is Equilateral, Isosceles or Scalene");
            Console.WriteLine("Let's make a triangle!");
            Console.Write("Enter the first side length: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second side length: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third side length: ");
            int s3 = int.Parse(Console.ReadLine());
            string ketqua1 = "This is an Equilateral triangle";
            string ketqua2 = "This is an Isosceles triangle";
            string ketqua3 = "This is a Scalene triangle";
            if (s1 == s2)
            {
                if (s1 == s3)
                {
                    Console.WriteLine(ketqua1);
                }
                else
                {
                    Console.WriteLine(ketqua2);
                }
            }
            else if (s1 == s3)
            {
                Console.WriteLine(ketqua2);
            }
            else
            {
                Console.WriteLine(ketqua3);
            }
        }
        static void Bai5()
        { 
            Console.WriteLine("\nBai5: write a program to accept a coordinate point in an XY coordinate system ad determine in which quadrant the coordinate point lies");
            Console.Write("Input the value for X coordinate: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: ");
            int Y = int.Parse(Console.ReadLine());
            if (Y == 0 && X == 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies at the origin.");
            }
            else if (X == 0 && Y != 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies on the Y-axis.");
            }
            else if (X != 0 && Y == 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies on the X-axis.");
            }
            else
            {
                if (X > 0)
                {
                    if (Y > 0)
                    {
                        Console.WriteLine($"The coordinate point ({X},{Y}) lies in the First quadrant.");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Fourth quadrant.");
                    }
                }
                else if (X < 0)
                {
                    if (Y > 0)
                    {
                        Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Second quadrant.");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Third quadrant.");
                    }
                }
                

            }
        }
        static void Mainn(string[] args)
        { Bai5(); } 

    }
}
