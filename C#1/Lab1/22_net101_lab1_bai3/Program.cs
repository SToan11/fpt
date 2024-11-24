using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_tinhthetich
{
    class Program
    {
        static void Main(string[] args)
        {
            int canh;
            double thetich;
            Console.Write("Nhap canh: ");
            canh = int.Parse(Console.ReadLine());
            //tinh toan
            thetich= Math.Pow(canh, 3);
            Console.WriteLine("The tich: " +thetich);
        }
    }
}