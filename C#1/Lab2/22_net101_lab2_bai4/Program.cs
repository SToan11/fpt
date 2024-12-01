using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_SoNguyenTo;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Kiểm tra số nguyên tố");
        Console.Write("Nhập số: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        if (number < 2)
        {
            Console.WriteLine($"{number} không phải là số nguyên tố");
        }
        int a = 2;
        while (a < number)
        {
            if (number % a == 0)
            {
                count++;
            }
            a++;
        }
        if (count > 0)
        {
            Console.WriteLine($"{number} không phải là số nguyên tố");
        }
        else
        {
            Console.WriteLine($"{number} là số nguyên tố");
            Console.ReadKey();
        }

    }
}