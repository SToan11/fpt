using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_tinhchuvi_dientich
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            //int chieudai, chieurong;
            //float dientich, chuvi, canhnhonhat;

            //Console.Write("Nhap chieu dai: ");
            //chieudai = int.Parse(Console.ReadLine());

            //Console.Write("Nhap chieu rong: ");
            //chieurong = int.Parse(Console.ReadLine());
            //canhnhonhat = Math.Min(chieudai, chieurong);
            ////tinh toan
            //chuvi = (chieudai + chieurong) * 2;
            //dientich = chieudai * chieurong;
            //Console.WriteLine("Chu vi: " + chuvi);
            //Console.WriteLine("Dien tich: " + dientich);
            //Console.WriteLine("Canh nho nhat: " + canhnhonhat);



            int T = 11;
            int i=0;
            int s=0;
            for (i = 1; i <= T; i++)
            {
                s = s + i;
                if (s  + i > T) break;
            }

            Console.WriteLine(s);
            Console.WriteLine(i);


        }
    }
}