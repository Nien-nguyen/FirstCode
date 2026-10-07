using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq.Expressions;

namespace FirstCode.ss8
{
    internal class BAI_TAP_FILES
    {
        static void createblankfile(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Close();
                    Console.WriteLine($"File '{filepath}' created successfully");
                }
                else
                {
                    Console.WriteLine($"File '{filepath}' already exists on disk");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AN error occurred: " + ex.Message);
            }
        }
        static void removefile(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                    Console.WriteLine($"Da xoa file '{filepath}' thanh cong");
                }
                else
                {
                    Console.WriteLine($"File '{filepath}' khong ton tai tren dia");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }

        }
        static void taofilevaghitext(string filepath, string ndung)
        {
            createblankfile(filepath);
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    writer.WriteLine(ndung);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
        static void taofilevadoctext(string filepath)
        { 
            taofilevaghitext(filepath, "Hello, this is a sample text.");
            if (File.Exists(filepath))
            {
                Console.WriteLine($"Noi dung cua file '{filepath}':");
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            
        }
        static List<string> taochuoi()
        {
            Console.Write("Nhap so luong cau muon nhap: ");
            int i = int.Parse(Console.ReadLine());
            List<string> context = new List<string>();
            for (int j = 0; j < i; j++)
            {
                Console.Write($"Nhap cau thu {j + 1}: ");
                context.Add(Console.ReadLine());
            }
            return context;
        }
        static void taofilevaghichuoi(string filepath)
        {
            List<string> context = taochuoi();
            createblankfile(filepath);
            File.AppendAllLines(filepath, context);
        }
        static void Main(string[] args)
        {
            string filepath = "myfile.txt";
            createblankfile(filepath);
            removefile(filepath);
            Console.Write("Nhap noi dung can ghi vao file: ");
            string ndung = Console.ReadLine();
            //taofilevaghitext(filepath, ndung);
            //taofilevadoctext(filepath);
            taofilevaghichuoi(filepath);
        }
    }
}
