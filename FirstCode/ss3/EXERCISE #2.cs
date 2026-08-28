using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
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
            decimal csm = 0, csc = 0;
            //Console.Write("Nhập số điện cũ (kWh): ");
            //decimal csc = decimal.Parse(Console.ReadLine());
            //Console.Write("Nhập số điện mới (kWh): ");
            //decimal csm = decimal.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("Nhập số điện cũ (kWh): ");
                csc = decimal.Parse(Console.ReadLine());
                Console.Write("Nhập số điện mới (kWh): ");
                csm = decimal.Parse(Console.ReadLine());
                if (csm >= csc)
                { break; }
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
            }
            //while (csm < csc)
            //{
            //    Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
            //    Console.Write("Nhập lại số điện mới (kWh): ");
            //    csm = decimal.Parse(Console.ReadLine());
            //    Console.Write("Nhập số điện cũ (kWh): ");
            //    csc = decimal.Parse(Console.ReadLine());
            //}
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
            else if ((tieuthu <= 200))
            {
                total = 50 * 1806 + 50 * 1866 + (tieuthu - 100) * 2167;
            }
            else if (tieuthu <= 300)
            {
                total = 50 * 1806 + 50 * 1866 + 100 * 2167 + (tieuthu - 200) * 2729;
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
            double bmi = Math.Round((cn / (cc * cc)), 2);
            string tt = "-";
            if (bmi < 18.5)
            {
                tt = "Gầy (Thiếu cân)";
            }
            else if (18.5 <= bmi && bmi < 23.0)
            {
                tt = "Bình thường (Lý tưởng)";
            }
            else if (23.0 <= bmi && bmi < 25.0)
            {
                tt = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                tt = "Béo phì";
            }
            double min_weight = Math.Round((18.5 * cc * cc), 2);
            double max_weight = Math.Round((22.9 * cc * cc), 2);
            Console.WriteLine("---OUTPUT---");
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi}");
            Console.WriteLine($"Phân loại sức khỏe: {tt}");
            Console.WriteLine($"Cân nặng lý tưởng của bạn nên từ {min_weight} kg đến {max_weight} kg.");
            Console.ReadKey();
        }
        static void Main3(string[] args) //Bai 3: Ứng dụng Quy đổi tiền tệ đa tỷ giá ngân hàng
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            Console.Write("Nhập số tiền VND: ");
            decimal vnd = decimal.Parse(Console.ReadLine());
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            byte pick = byte.Parse(Console.ReadLine());
            while (pick > 4)
            {
                Console.WriteLine("Chọn sai ngoại tệ, vui lòng chọn lại");
                Console.Write("Chọn ngoại tệ: ");
                pick = byte.Parse(Console.ReadLine());
            }
            decimal ser = (1m / 200m) * vnd;
            decimal vnd_doi = vnd - ser;
            string dvi = "-";
            decimal total = 0;
            if (pick < 2)
            {
                total = vnd_doi / 25400;
                dvi = "USD";
            }
            else if (pick < 3)
            {
                total = vnd_doi / 27200;
                dvi = "EUR";
            }
            else if (pick < 4)
            {
                total = vnd_doi / 165;
                dvi = "JPY";
            }
            else
            {
                total = vnd_doi / 32100;
                dvi = "GBP";
            }
            Console.WriteLine("---OUTPUT---");
            Console.WriteLine($"Phí dịch vụ (0.5%): {ser:#,##0} VND");
            Console.WriteLine($"Số tiền VND tính đổi: {vnd_doi:#,##0} VND");
            Console.WriteLine($"Số tiền {dvi} nhận được: {Math.Round(total, 2):#,##0} {dvi}");
        }
        static void Main4(string[] args) //Bai 4: Tính tuổi chính xác & Đếm ngược ngày sinh nhật

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            DateTime bday;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string date = Console.ReadLine();
                if (DateTime.TryParseExact(date,
                                           "dd/MM/yyyy",
                                           CultureInfo.InvariantCulture,
                                           DateTimeStyles.None,
                                           out bday))
                {
                    break;
                }
                Console.WriteLine("Định dạng ngày sinh không hợp lệ.");

            }
            DateTime now = DateTime.Now.Date;
            int tuoi = now.Year - bday.Year;

            DateTime nextbday = new DateTime(now.Year, bday.Month, bday.Day);
            if (nextbday < now)
            {
                nextbday = nextbday.AddYears(1);
            }
            TimeSpan so_ngay_da_song = (now - bday);
            TimeSpan sinh_nhat_tiep_theo = nextbday - now;

            Console.WriteLine("\n---OUTPUT---");
            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {so_ngay_da_song.Days} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo: {sinh_nhat_tiep_theo.Days} ngày nữa");
            Console.ReadLine();

        }
        static void Main5(string[] args) //Bai 5: Quản lý điểm học phần & Quy Đổi thang điểm GPA (4.0)
        {
            Console.OutputEncoding = (Encoding.UTF8);
            Console.Write("C# (4 TC): ");
            double c_sharp = double.Parse(Console.ReadLine());
            Console.Write("Toán (3 TC): ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Tiếng Anh (2 TC): ");
            double anh = double.Parse(Console.ReadLine());
            var tbts = (c_sharp * 4 + toan * 3 + anh * 2) / (4 + 3 + 2);
            string gpa = "-";
            string diem = "-";
            string xep_loai = "-";
            if (tbts >= 8.5 && tbts <= 10)
            {
                gpa = "4.0";
                diem = "A";
                xep_loai = "Xuất sắc/ Giỏi";
            }
            else if (tbts >= 7.0)
            {
                gpa = "3.0";
                diem = "B";
                xep_loai = "Khá";
            }
            else if (tbts >= 5.5)
            {
                gpa = "2.0";
                diem = "C";
                xep_loai = "Trung bình";
            }
            else if (tbts >= 4.0)
            {
                gpa = "1.0";
                diem = "D";
                xep_loai = "Yếu";
            }
            else
            {
                gpa = "0.0";
                diem = "F";
                xep_loai = " Kém (Trượt) ";
            }
            Console.WriteLine("\n---OUTPUT---");
            Console.WriteLine($"Điểm TB Thang 10: {Math.Round(tbts, 2)}");
            Console.WriteLine($"Điểm Chữ quy đổi: {diem}");
            Console.WriteLine($"Điểm GPA thang 4: {gpa}");
            Console.WriteLine($"Xếp loại học lực: {xep_loai}");
            Console.ReadKey();

        }
        static void Main6(string[] args) //Bai 6: Chuẩn hóa họ tên người dùng & tự động tạo email/ username
        {
            Console.OutputEncoding = (Encoding.UTF8);
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            string ten = "-";
            while (true)
            {
                Console.Write("Nhập họ tên thô: ");
                ten = Console.ReadLine();
                if (ten == null)
                {
                    Console.WriteLine("Nhập lại tên thô");
                }
                else { break; }
            }
            ten = ten.Trim();
            string[] parts = ten.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                string word = parts[i].ToLower();
                parts[i] = char.ToUpper(word[0]) + word.Substring(1);

            }
            string tencuoi = string.Join(" ", parts);
            Console.WriteLine("\n---OUTPUT---");
            Console.WriteLine($"Họ tên chuẩn hóa: {tencuoi}");
            parts = tencuoi.Split(' ');
            List<string> ten_dem = new List<string>();
            for (int i = 1; i < parts.Length - 1; i++)
            {
                ten_dem.Add(parts[i]);
            }
            string name = parts[parts.Length - 1];
            string[] ten_dem_str = ten_dem.ToArray();

            Console.WriteLine($"Họ: {parts[0]} \\ Tên đệm: {string.Join(" ", ten_dem_str)} \\ Tên: {name}");
            string username = name.ToLower() + "." + parts[0].ToLower() + string.Join("", ten_dem_str).ToLower();
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {username}@company.edu.vn");

        }
        static void Main7(string[] args) //Bai 7: Lập kế hoạch chi phí nhiên liệu & chia sẻ chuyến đi (car-pooling)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            Console.Write("Quãng đường (km): ");
            double kcach = double.Parse(Console.ReadLine());
            Console.Write("Mức tiêu hao (L/100km): ");
            double tieuthu = double.Parse(Console.ReadLine());
            Console.Write("Giá xăng (VND/Lít): ");
            decimal gia = decimal.Parse(Console.ReadLine());
            Console.Write("Số người đi: ");
            int num = int.Parse(Console.ReadLine());
            double tong_xang = (kcach / 100) * tieuthu;
            decimal totalcost = (decimal)tong_xang * gia;
            decimal per = Math.Ceiling((totalcost / (decimal)num) / 1000) * 1000;
            Console.WriteLine("\n---OUTPUT---");
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tong_xang:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {totalcost:#,##0} VND");
            Console.WriteLine($"Chi phí mỗi người: {per:#,##0} VND");
            Console.ReadKey();
        }
        static void Main8(string[] args) //Bai 8: Kiểm tra mã xác thực OTP & quản lý thời gian hiệu lực
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---INPUT---");
            int otpdung = 839201;
            int otpnhap;
            while (true)
            {
                Console.Write("Mã OTP nhận được: ");
                if (int.TryParse(Console.ReadLine(),out otpnhap))
                {
                    break;
                }
                Console.WriteLine("Mã OTP chỉ bao gồm số");
            }
            string tgian;
            Console.Write("Thời gian trôi qua (-phut-giay): ");
            tgian = Console.ReadLine();
            string[] time = tgian.Split(" ");
            TimeSpan timenhap = new TimeSpan(0,int.Parse(time[0]), int.Parse(time[4]));
            DateTime creationtime = DateTime.Now;
            TimeSpan timelimit = new TimeSpan(0, 5, 0);
            bool timeresult;
            bool otpresult;
            string final;
            if (timenhap > timelimit)
            {
                timeresult = false;
            }
            else
            {
                timeresult = true;
            }
            if (otpnhap == otpdung)
            {
                otpresult = true;
            }
            else
            {
                otpresult = false;
            }

            if (timeresult==true && otpresult==true)
            {
                final = $"THÀNH CÔNG - Giao dịch đã được phê duyệt.";
                if (timeresult == true && otpresult == false)
                {
                    final = "LỖI - Mã OTP không hợp lệ";
                    if (timeresult == false && otpresult == true)
                    {
                        final = "LỖI - Hết hạn OTP";
                    }
                    else
                    {
                        final = "LỖI - Hết hạn OTP và Mã OTP không hợp lệ";
                    }
                }
            }

        }
        
    }
}
