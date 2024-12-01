using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Ptbac1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            //nhap a
            Console.Write("Nhap a: "); 
            //yêu cầu nhập vào số a
            a = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a phai khac 0");
                return;
            }
            //nhap b
            Console.Write("Nhap b: ");
            //yêu cầu nhập vào số b
            b = float.Parse(Console.ReadLine());
            float x = -b/a;
            Console.Write("{0}x + {1} = 0 \n => x={2}",a,b,x);
            Console.ReadKey();  
        }
    }
}