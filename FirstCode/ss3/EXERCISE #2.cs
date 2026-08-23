using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;

namespace FirstCode.ss3
{
    internal class EXERCISE__2
    {
     static void Main1(string[] args)//Bai 1: Tính tiền điện sinh hoạt gia đình theo bảng giá bậc thang
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            Console.Write("Nhập số điện cũ (kWh): ");
            decimal csc = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập số điện mới (kWh): ");
            decimal csm = decimal.Parse(Console.ReadLine());
            
            while (csm < csc)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
                Console.Write("Nhập lại số điện mới (kWh): ");
                csm = decimal.Parse(Console.ReadLine());
                Console.Write("Nhập số điện cũ (kWh): ");
                csc = decimal.Parse(Console.ReadLine());
            }
            decimal tieuthu = csm - csc;
            decimal total = 0;
            if (tieuthu <= 50)
            {
                total = 1806 * tieuthu;
            }
            else if (tieuthu <= 100)
            {
                total = 50 * 1806 + (tieuthu - 50) * 1866;
            }
            else if ( (tieuthu <= 200))
            {
                total = 50 * 1806 + 50 * 1866 + (tieuthu - 100)*2167;
            }
            else if (tieuthu <=300)
            {
                total = 50 * 1806 + 50 * 1866 + 100 * 2167 + (tieuthu - 200)*2729;
            }
            else
            {
                total = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (tieuthu - 300) * 3050;
            }
            decimal total_tax = total * 108 / 100;

            Console.WriteLine("---OUTPUT---:");
            Console.WriteLine($"Số điện tiêu thụ: {tieuthu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {total} VND");
            Console.WriteLine($"Thuế VAT: {total * 8 / 100} VND");
            Console.WriteLine($"Tổng thanh toán: {total_tax} VND");

        }
     static void Main2(string[] args) //Bai 2: Hệ thống theo dõi chỉ số BMI & Đánh giá Tình trạng Sức khỏe
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            Console.Write("Chiều cao (m): ");
            double cc = double.Parse(Console.ReadLine());
            Console.Write("Cân nặng (kg): ");
            double cn = double.Parse(Console.ReadLine());
            double bmi = Math.Round( (cn / (cc * cc)), 2);
            string tt = "-";
            if (bmi < 18.5)
            {
                tt = "Gầy (Thiếu cân)";
            }
            else if (18.5 <= bmi && bmi < 23.0)
            {
                tt = "Bình thường (Lý tưởng)";
            }
            else if (23.0<= bmi && bmi < 25.0)
            {
                tt = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                tt = "Béo phì";
            }
            double min_weight = Math.Round(( 18.5 * cc * cc),2);
            double max_weight = Math.Round((22.9 * cc * cc),2);
            Console.WriteLine("---OUTPUT---");
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi}");
            Console.WriteLine($"Phân loại sức khỏe: {tt}");
            Console.WriteLine($"Cân nặng lý tưởng của bạn nên từ {min_weight} kg đến {max_weight} kg.");
            Console.ReadKey();
        }
     static void Main(string[] args) //Bai 3: Ứng dụng Quy đổi tiền tệ đa tỷ giá ngân hàng
        {

        }
    }
}
