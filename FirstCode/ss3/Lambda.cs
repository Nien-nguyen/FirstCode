using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss3
{
    internal class Lambda
    {
        static void Main2(string[] args)
        {
            /* Lambda expressions là một hàm ẩn danh dùng để viết các đoạn logic ngắn gọn ngay tại nơi sử dụng mà không cần khai báo phương thức đầy đủ
             * Cú pháp tổng quát: (danh_sach_tham_so) => bieu_thuc_hoac_khoi_lenh
             * vế trái: đầu vào. Nếu có 1 tham số có thể bỏ dấu (), nếu ko hoặc có từ 2 tham số trở lên phải dùng dấu () (x, y)
             * Hai dạng của lambda expression:
             *           * 1. Biểu thức lambda (Expression Lambda): chỉ có 1 biểu thức, không có dấu {} và return
             *           * 2. Khối lệnh lambda (Statement Lambda): có nhiều biểu thức, có dấu {} và return
             */

            // Func<kieu_dau_vao, kieu_dau_ra> ten_bien = tham_so => phep_tinh;
            Func<int, int> myDeleg = a => a * a; // Lambda expression that takes an integer and returns its square
            int x = myDeleg(7) + 1;
            Console.WriteLine(x);


            int[] fib = {1,1,2,3, 5, 8, 13, 21, 34, 55 };
            double average = fib.Where(n => n % 2 == 1).Average();
            Console.WriteLine(average);
            // The above line uses a lambda expression to filter the odd numbers from the fib array and then calculates their average.


        }



    }
}
