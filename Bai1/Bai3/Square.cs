using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Square
    {
        public float canh;
        public static void HTCanh(float canh)
        {
            Console.WriteLine("Do dai canh la: " + canh);
        }
        public static void ChuVi(float canh)
        {
            float cv;
            cv= canh * 4;
            Console.WriteLine("Chu vi la: " + cv);
        }
        public static void DienTich(float canh)
        {
            float dt = canh * canh;
            Console.WriteLine("Dien tich la : " + dt);
        }
        public void HienThi()
        {
            HTCanh(canh);
            ChuVi(canh);
            DienTich(canh);
        }
    }
}
