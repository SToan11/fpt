using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_NgayThangNam
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập ngày
            Console.Write("Nhập ngày (1-31): ");
            int ngay = int.Parse(Console.ReadLine());
            // Nhập tháng
            Console.Write("Nhập tháng (1-12): ");
            int thang = int.Parse(Console.ReadLine());
            // Nhập năm
            Console.Write("Nhập năm: ");
            int nam = int.Parse(Console.ReadLine());
            // Kiểm tra tính hợp lệ của ngày, tháng
            if (KiemTraNgayThangHopLe(ngay, thang))
            {
                Console.WriteLine("Ngày tháng hợp lệ.");
                // Xác định số ngày trong tháng
                int soNgayTrongThang = SoNgayTrongThang(thang);
                Console.WriteLine($"Tháng {thang} có {soNgayTrongThang} ngày.");
                // Xác định ngày hôm sau
                DateTime ngayHomSau = NgayHomSau(ngay, thang);
                Console.WriteLine($"Ngày hôm sau là: {ngayHomSau.ToShortDateString()}");
                // Xác định ngày hôm trước
                DateTime ngayHomTruoc = NgayHomTruoc(ngay, thang);
                Console.WriteLine($"Ngày hôm trước là: {ngayHomTruoc.ToShortDateString()}");
            }else{
                Console.WriteLine("Ngày tháng không hợp lệ.");
            }
        }
        static bool KiemTraNgayThangHopLe(int ngay, int thang)
        {
            // Kiểm tra tính hợp lệ của ngày, tháng
            if (ngay < 1 || ngay > 31 || thang < 1 || thang > 12)
            {
                return false;
            }
            // Kiểm tra số ngày của tháng
            int[] soNgayTrongThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return ngay <= soNgayTrongThang[thang - 1];
        }
        static int SoNgayTrongThang(int thang)
        {
            int[] soNgayTrongThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return soNgayTrongThang[thang - 1];
        }
        static DateTime NgayHomSau(int ngay, int thang)
        {
            DateTime ngayHienTai = new DateTime(DateTime.Now.Year, thang, ngay);
            return ngayHienTai.AddDays(1);
        }
        static DateTime NgayHomTruoc(int ngay, int thang)
        {
            DateTime ngayHienTai = new DateTime(DateTime.Now.Year, thang, ngay);
            return ngayHienTai.AddDays(-1);
        }
    }
}