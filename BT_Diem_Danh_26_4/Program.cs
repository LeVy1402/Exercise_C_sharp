using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BT_Diem_Danh_26_4
{ 
    class PhuongTrinh
    {
        private double _a_170 { set; get; }
        private double _b_170 { set; get; }
        private double _c_170 { set; get; }

        public PhuongTrinh()
        {
            _a_170 = 1;
            _b_170 = 2;
            _c_170 = 3;
        }
        public PhuongTrinh(double a, double b, double c)
        {
            _a_170 = a;
            _b_170 = b;
            _c_170 = c;
        }
        public double Delta(double a_170, double b_170, double c_170)
        {
            double delta_170;
            delta_170 = b_170 * b_170 - 4 * a_170 * c_170;
            return delta_170;
        }
        public void nghiem(double a_170, double b_170, double c_170, double delta_170)
        {
            if (delta_170 > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b_170 - Math.Sqrt(delta_170)) / 2 * a_170));
                Console.WriteLine("X2 = {0}", ((-b_170 + Math.Sqrt(delta_170)) / 2 * a_170));

            }
            else if (delta_170 == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b_170 / 2 * a_170);
            }
            else if (delta_170 < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a_170, b_170, c_170, delta_170;
            Console.WriteLine("Nhập a, b, c: ");
            string[] so_170 = Console.ReadLine().Split(' ');
            a_170 = float.Parse(so_170[0]);
            b_170 = float.Parse(so_170[1]);
            c_170 = float.Parse(so_170[2]);
            PhuongTrinh pt = new PhuongTrinh();
            delta_170 = pt.Delta(a_170, b_170, c_170);
            pt.nghiem(a_170, b_170, c_170, delta_170);
            Console.ReadKey();
        }
    }
}
