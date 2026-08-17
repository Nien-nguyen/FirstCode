using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss2
{
    internal class BTTH1
    {
        private static void Main(string[] args)
        {
            //1. To Add/ Sum two numbers
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is: {num1 + num2}");

            // 2. To swap values of two variables
            Console.Write("Name an animal: ");
            string animal1 = Console.ReadLine();
            string temp = animal1;
            Console.Write("Name another animal: ");
            string animal2 = Console.ReadLine();
            animal1 = animal2;
            animal2 = temp;
            Console.WriteLine($"After swapping, the 1st animal: {animal1} and the 2nd animal: {animal2}");
            
            

            //3. To multiply two floating point numbers
            Console.Write("Enter a floating number: ");
            float float1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a second floating number: ");
            float float2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"The answer when multiplying the two floating numbers is: {float1 * float2}");

            //4. To convert feet to meter
            Console.Write("How many feet do you want to convert to meters? ");
            float feet = Convert.ToSingle(Console.ReadLine());
            float meters = feet * 0.3048f;
            Console.WriteLine($"{feet} feet is equal to {meters} meters");

            //5. To convert Celsius to Fahrenheit
            Console.Write("What is the temprature now in Celcius? ");
            float cel = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"It is {(cel * 1.8f) + 32} degrees fahrenheit");
            Console.Write("What is the temprature now in Fahrenheit? ");
            float fah = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"It is {(fah - 32) / 1.8f} degrees celcius");

            //6. To find the size of data types
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
            Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");

            //7. To print ASCII value
            Console.Write("Enter a character: ");
            int c = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {c}");

            //8. To calculate area of circle
            Console.Write("Enter the radius of the circle: ");
            float rad = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"The area of your circle is: {3.14f * rad * rad}");

            //9. To calculate area of square
            Console.Write("Give me the length of the square: ");
            float len = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"The area of your square is: {len * len}");

            //10. To convert days to years, weeks and days
            Console.Write("Enter your days(>=365): ");
            int day = Convert.ToInt32(Console.ReadLine());
            int year = day / 365;
            int week = (day - year * 365) / 7;
            int dayleft = day - year * 365 - week * 7;
            Console.WriteLine($"It is {year} years, {week} weeks and {dayleft} days");

        }
    }
}
