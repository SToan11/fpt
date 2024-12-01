using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BangCuuChuong;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bảng cửu chương");

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j}\t");
            }
            Console.WriteLine();
        }
    }
}
