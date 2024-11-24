using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_tinhDelta
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            //nhap a
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            //nhap b
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            //nhap c
            Console.Write("Nhap c: ");
            c = float.Parse(Console.ReadLine());
            // Tính delta
            double delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("delta= " + delta);
            //can delta
            double candelta = Math.Sqrt(delta);
            Console.WriteLine("candelta= " + candelta);
        }
    }
}