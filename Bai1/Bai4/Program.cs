using System;
using System.Collections;
namespace Bai4
{
    class Program
    { 
        static void Main(string[] args)
        {
            News ds = new News();
            int choose;
            
            do
            {
                
                Console.WriteLine("Moi chon cac muc sau: ");
                Console.WriteLine("1 - Insert News");
                Console.WriteLine("2 - View list news");
                Console.WriteLine("3 - Average Rate");
                Console.WriteLine("4 - Exit");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ds.Nhap();
                        break;
                    case 2:
                        ds.display();
                        break;
                    case 3:
                        ds.calculate();
                        ds.display();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
            
                }
            }
            while (choose >= 1 || choose <= 4);
            Console.ReadKey();
        }
    }
}
