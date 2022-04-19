using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Shape a = new Triangle(new _2DPoint(1, 1), new _2DPoint(1, 3), new _2DPoint(3, 1));
            Console.WriteLine(a.ToString());
            Console.Write("Nhap khoang cac tinh tien: ");
            a = a.TinhTien(int.Parse(Console.ReadLine()));
            Console.WriteLine("Sau khi tinh tien: \n" + a.ToString());
            Console.ReadKey();
        }
    }
}
