using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FirstCode.ss3
{
    internal class EXERCISE__2
    {
     static void Main(string[] args)
        {
            //Bai 1: Tính tiền điện sinh hoạt gia đình theo bảng giá bậc thang
            Console.OutputEncoding = Encoding.UTF8;
            decimal csc, csm; 
            do
            {
                Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ. Vui lòng nhập lại.");
                Console.Write("Nhập chỉ số điện mới (kWh): ");
            }
            while (csm < csc);
        }
    }
}
