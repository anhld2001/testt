using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void TinhTien(int a)
        {
            int tiendien;
            if(0<a && a<25)
            {
                tiendien = a * 1000;
            }
            else if( 25<a && a<75)
            {
                tiendien = a * 1250;
            }
            else if( 75<a && a<150)
            {
                tiendien = a * 1800;
            }
            else
            {
                tiendien = a * 2500;
            }
            Console.WriteLine("So tien dien phai tra la: " + tiendien);
        }
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Nhap so dien: ");
                a = int.Parse(Console.ReadLine());
            }
            while (a < 0);
            TinhTien(a);
            Console.ReadKey();
        }
    }
}
