using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{

    class Program : Square
    {
        public static void Check(float canh)
        {
            HTCanh(canh);
            ChuVi(canh);
            DienTich(canh);
        }
        static void Main(string[] args)
        {
            Check(4);
            Console.ReadKey();
        }
    }
}
