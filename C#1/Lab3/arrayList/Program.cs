using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListdemo;
class Program
{
    static void NhapMang(ArrayList a,int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so phan tu thu a[{0}]:", i);
            a.Add(int.Parse(Console.ReadLine()));
        }
    }
    static void XuatMang(ArrayList a,int n)
    {
        foreach (int x in a)
            Console.Write(x + " ");
        Console.Write("\n");
    }
    static int Timgiatrinhonhat(ArrayList a)
    {
        int min = (int)a[0];
        foreach (int x in a)
        {
            if (x < min)
            {
                min = x;
            }
        }
        return min;
    }
    static float TrungBinhCong(ArrayList a)
    {
        int tong = 0;
        int dem = 0;
        foreach (int x in a)
            if (x % 3 == 0)
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
        ArrayList b = new ArrayList();
        NhapMang(b, n);
        XuatMang(b, n);
        Console.WriteLine("Giá trị nhỏ nhất là: " + Timgiatrinhonhat(b));
        Console.WriteLine("Trung bình cộng các phần tử chia hết cho 3 là: " + TrungBinhCong(b));
        Console.ReadKey();
    }

}