using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class News : INews
    {
        
        public int id { get; set; }
        public string title { get; set; }
        public string publishDate { get; set; }
        public string author { get; set; }
        public string content { get; set; }
        public float averageRate { get; set; }
        public ArrayList ds = new ArrayList();
        public News() { }
        public News(int id, string title, string publishDate, string author, string content, float averageRate) {

            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;
            this.averageRate = averageRate;
        }

        public void display()
        {
            foreach(News item in ds)
            {
                Console.WriteLine("" + item.title);
                Console.WriteLine("" + item.publishDate);
                Console.WriteLine("" + item.author);
                Console.WriteLine("" + item.content);
                Console.WriteLine("" + item.averageRate);
            }
            
        }

        public int[] rateList = new int[3];
        public void calculate()
        {
            averageRate = (rateList[0] + rateList[1] + rateList[2]) / 3;
            foreach (News item in ds)
            {
                Console.WriteLine("" + item.title);
                Console.WriteLine("" + item.publishDate);
                Console.WriteLine("" + item.author);
                Console.WriteLine("" + item.content);
                item.averageRate = (item.rateList[0] + item.rateList[1] + item.rateList[2]) / 3;
                Console.WriteLine("" + item.averageRate);
            }
        }

        public void Nhap()
        {
            News ds1 = new News();
            Console.WriteLine("Nhap title: ");
            ds1.title = Console.ReadLine();
            Console.WriteLine("Nhap ngay xuat ban : ");
            ds1.publishDate = Console.ReadLine();
            Console.WriteLine("Nhap tac gia: ");
            ds1.author = Console.ReadLine();
            Console.WriteLine("Nhap content: ");
            ds1.content = Console.ReadLine();
            Console.WriteLine("Nhap danh gia 1 : ");
            ds1.rateList[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap danh gia 2 : ");
            ds1.rateList[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap danh gia 3 : ");
            ds1.rateList[2] = int.Parse(Console.ReadLine());
            ds.Add(ds1);
        }

    }
}
