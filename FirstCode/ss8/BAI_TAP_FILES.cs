using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

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
        //6
        static void appendtext(string filepath)
        {
            List<string> context = taochuoi();
            if (File.Exists(filepath))
            {
                File.AppendAllLines(filepath, context);
            }
            else
            {
                Console.WriteLine($"File '{filepath}' khong ton tai tren dia");
            }
        }
        //7
        static void copyvain(string filepath)
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                string copyfilepath = "copyfile.txt";
                File.WriteAllLines(copyfilepath, lines);
                Console.WriteLine($"Da sao chep noi dung cua file '{filepath}' sang file '{copyfilepath}'");
                Console.WriteLine(lines);
            }
        }
        //8
        static void create_and_move_a_file()
        {
            string og = "original.txt";
            string moved = "movedfile.txt";
            try
            {
                using (StreamWriter sw = File.CreateText(og))
                {
                    sw.WriteLine("This is the original file.");
                }
                Console.WriteLine($"Da tao file thanh cong: '{og}'");
                if (File.Exists(moved))
                {
                    File.Delete(moved);
                    Console.WriteLine($"Da xoa file '{moved}'");
                }
                if (File.Exists(og))
                {
                    File.Move(og, moved);
                    Console.WriteLine($"Da di chuyen file '{og}' sang '{moved}'");
                }
                else
                {
                    Console.WriteLine($"File '{og}' khong ton tai tren dia");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
        static void read1stline(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Console.WriteLine(lines[0]);
        }
        static void readlastline(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Console.WriteLine(lines[lines.Length - 1]);
        }
        static void readlastnline(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Console.Write("Nhap so n dong cuoi cung muon doc: ");
            int n = int.Parse(Console.ReadLine());
            if (n>lines.Length)
            {
                Console.WriteLine("So dong muon doc vuot qua noi dung file");
            }
            else if (n<=0)
            {
                Console.WriteLine("So dong muon doc phai lon hon 0");

            }
            else
            {
                for (int i = lines.Length - n; i<lines.Length;i++)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
        static void read_nth_line(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Console.Write("Nhap dong muon doc: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(lines[n - 1]);
        }
        static void demlines(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            int n = lines.Length;
            Console.WriteLine($"File '{filepath}' co {n} dong");
        }
        static void printfolderstructure(DirectoryInfo dir, string indent=" ")
        {
            try
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine($"{indent}├── {file.Name}");
                }
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    printfolderstructure(subDir, indent + "    ");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"{indent} [bi chan quyen truy cap]");
            }
        }
        static void Bai14()
        {
            string path = @"C:\Users\Public";
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                Console.WriteLine(dirInfo.Name);
                printfolderstructure(dirInfo);
            }
            else
            {
                Directory.CreateDirectory(path);
                File.Create(Path.Combine(path, "test_file.txt")).Close();
                Console.WriteLine($"\n[Thong bao] Da tao thu muc '{path}' va file 'test_file.txt' trong thu muc do.");
            }

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
            appendtext(filepath);
            copyvain(filepath);
        }
    }
}
