using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_GiaiPTbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập các hệ số từ bàn phím
            Console.Write("Nhập hệ số a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            // Xét a
            if (a == 0) {
                // Giải phương trình bậc 1
                GiaiPhuongTrinhBacMot(b, c);
            } else {
                // Tính delta
                double delta = b * b - 4 * a * c;
                // Xử lý theo giá trị delta
              if (delta < 0) {
                   Console.WriteLine("Phương trình không có nghiệm thực.");
              } else if (delta == 0) {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Nghiệm kép: x = {x}");
                } else {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Nghiệm 1: x1 = {x1}, Nghiệm 2: x2 = {x2}");
                }
            }
        }
        static void GiaiPhuongTrinhBacMot(double b, double c)
        {
            // Giải phương trình bậc 1: bx + c = 0
            if (b == 0) {
                if (c == 0) {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                } else {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            } else {
                double x = -c / b;
                Console.WriteLine("Nghiệm phương trình bậc 1: x = {x}");
            }
        }
    }
}
