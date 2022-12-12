using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void PT(float a, float b, float c)
        {
            float n1, n2;
            float d = b * b - 4 * a * c;
            if(d < 0 )
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }    
            else if( d > 0)
            {
                 n1 = (float)(-b + Math.Sqrt(d)) / (2 * a);
                n2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem la: " + n1 + "va" + n2);
            }
            else
            {
                n1 = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: " + n1);
            }
        }

        static void Main()
        {
            float a, b, c;
            Console.WriteLine("Nhap a: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = float.Parse(Console.ReadLine());

            PT(a, b, c);
            Console.ReadKey();
        }
    }
}
