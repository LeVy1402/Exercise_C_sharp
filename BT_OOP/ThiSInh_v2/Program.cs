using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiSinh_v2
{
    class ThiSinh
    {
        private int _SBD;
        private string _HoTen;
        private string _DiaChi;
        private int _MucUuTien;        

        public int SBD { get { return _SBD; } set { this._SBD = value; } }
        public string HoTen { get { return _HoTen; } set { this._HoTen = value; } }
        public string DiaChi { get { return _DiaChi; } set { this._DiaChi = value; } }
        public int MucUuTien { get { return _MucUuTien; } set { this._MucUuTien = value; } }
        //public string Khoi { get { return _Khoi; } set { this._Khoi = value; } }

        //public ThiSinh(int sBD, string hoTen, string diaChi, int mucUuTien)
        //{
        //    SBD = sBD;
        //    HoTen = hoTen;
        //    DiaChi = diaChi;
        //    MucUuTien = mucUuTien;         
        //}
        public ThiSinh() { }

        public void Input()
        {
            Console.Write("Nhập số báo danh: ");
            SBD = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập mức ưu tiên: ");
            MucUuTien = int.Parse(Console.ReadLine());
        }

        public virtual void Show()
        {
            Console.WriteLine("Số báo danh: " + SBD);
            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("Địa chỉ: " + DiaChi);
            Console.WriteLine("Mức ưu tiên: " + MucUuTien);
        }
    }

    class KhoiA : ThiSinh
    {       
        public void Input()
        {
            base.Input();
        }
        override
        public void Show()
        {
            base.Show();
            Console.WriteLine("Khối thi: Toán, Lý, Hóa");
        }
    }

    class KhoiB : ThiSinh
    {      
        public void Input()
        {
            base.Input();
        }
        override
        public void Show()
        {
            base.Show();
            Console.WriteLine("Khối thi: Lý, Hóa, Sinh");
        }
    }

    class KhoiC : ThiSinh
    {
        public void Input()
        {
            base.Input();
        }
        override
        public void Show()
        {
            base.Show();
            Console.WriteLine("Khối thi: Văn, Sử, Địa");
        }
    }
    internal class Program
    {
        static List<ThiSinh> list = new List<ThiSinh>();
        static void Option()
        {
            Console.WriteLine("================");
            Console.WriteLine("\t 1. Khối A");
            Console.WriteLine("\t 2. Khối B");
            Console.WriteLine("\t 3. Khối C");
            Console.Write("Chọn khối: ");
        }
        static void ThemMoi()
        {
            ThiSinh ts = new ThiSinh();
            Console.Write("Nhập số lượng thí sinh ");
            int sl = int.Parse(Console.ReadLine());            
            for(int i=0; i<sl; i++)
            {
                Console.WriteLine("Nhập thông tin thí sinh thứ " + (i + 1));
                Option();
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ts = new KhoiA();                     
                        break;
                    case 2:
                        ts = new KhoiB();
                        break;
                    case 3:
                        ts = new KhoiC();
                        break;
                }
                ts.Input();
                list.Add(ts);
            }
        }
        static void Show()
        {
            foreach(var ts in list){
                ts.Show();
            }
        }
        static void TimKiem()
        {
            Console.Write("Nhập số báo danh cần tìm kiếm ");
            int sbd = int.Parse(Console.ReadLine());
            var rs = list.FirstOrDefault(x => x.SBD == sbd);
            rs.Show();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemMoi();
            Show();
            TimKiem();
            Console.ReadKey();
        }
    }
}
