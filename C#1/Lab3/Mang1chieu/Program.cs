using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;


namespace MangThongThuong;
    class Program  
    {
        static void NhapMang(int []a)
        {
            for(int i=0; i<a.Length; i++)
            {
                Console.Write("Nhap so phan tu thu a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[]a)
        {
            foreach(int x in a) 
                Console.Write(x+" ");
            Console.Write("\n");
        }
    //tìm giá trị nhỏ nhất
        static int Timgiatrinhonhat(int[] a)
        {
            int min = a[0];
            foreach(int x in a)
                if(x < min)
                    min = x;
            return min;
        }
        //tính trung bình cộng
        static float TrungBinhCong(int[] a)
        {
            int tong = 0;
            int dem = 0;
            foreach (int x in a)
                if(x%3 == 0)
                {
                    tong += x;
                    dem++;
                }
                return (float)tong / dem;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            int[] b=new int[n];
            NhapMang(b);
            XuatMang(b);
            Console.Write("Phan tu nho nhat la {0}:\n", Timgiatrinhonhat(b));
            Console.Write("tbc cac phan tu chia het cho 3 la: {0}", TrungBinhCong(b));
            Console.ReadKey();
        }
    
}