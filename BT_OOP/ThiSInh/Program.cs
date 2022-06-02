using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace ThiSinh
{
    class ThiSinh
    {
        //Số báo danh, họ tên, địa chỉ, mức ưu tiên.
        private int _SBD;
        private string _HoTen;
        private string _DiaChi;
        private int _MucUuTien;
        //private string _Khoi;      

        public int SBD { get { return _SBD; } set { this._SBD = value; } }
        public string HoTen { get { return _HoTen; } set { this._HoTen = value; } }
        public string DiaChi { get { return _DiaChi; } set { this._DiaChi = value; } }
        public int MucUuTien { get { return _MucUuTien; } set { this._MucUuTien = value; } }
        //public string Khoi { get { return _Khoi; } set { this._Khoi = value; } }

        public ThiSinh(){}

        public ThiSinh(int SBD, string HoTen, string DiaChi, int MucUuTien)
        {
            this.SBD = SBD;
            this.HoTen = HoTen;
            this.DiaChi = HoTen;
            this.MucUuTien = MucUuTien;
            //this.Khoi = Khoi;
        }



        public virtual void Show()
        {
            Console.WriteLine("Số báo danh: " + _SBD);
            Console.WriteLine("Họ tên: " + _HoTen);
            Console.WriteLine("Địa chỉ: " + _DiaChi);
            Console.WriteLine("Mức ưu tiên: " + _MucUuTien);
        }



        public void Input()
        {
            Console.Write("Nhập số báo danh: ");
            _SBD = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            _HoTen = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            _DiaChi = Console.ReadLine();
            Console.Write("Nhập mức ưu tiên: ");
            _MucUuTien = int.Parse(Console.ReadLine());
        }
    }
    class KhoiA : ThiSinh
    {
        public KhoiA(int SBD, string HoTen, string DiaChi, int MucUuTien) : base(SBD, HoTen, DiaChi, MucUuTien)
        {
        }

        public void Input()
        {
            base.Input();        
        }

        
        public override void Show()
        {
            base.Show();
            //Console.WriteLine("Khối thi: " + Khoi);
        }
    }
    class KhoiB : ThiSinh
    {
        public KhoiB(int SBD, string HoTen, string DiaChi, int MucUuTien) : base(SBD, HoTen, DiaChi, MucUuTien)
        {
        }
        public void Input()
        {
            base.Input();
        }
        public void Show()
        {
            base.Show();
        }
    }
    class KhoiC : ThiSinh
    {
        public KhoiC(int SBD, string HoTen, string DiaChi, int MucUuTien) : base(SBD, HoTen, DiaChi, MucUuTien)
        {
        }
        public void Input()
        {
            base.Input();
        }
        public void Show()
        {
            base.Show();
        }
    }



    class TuyenSinh
    {
        static List<ThiSinh> thisinh = new List<ThiSinh>();
        static public void ThemThiSinh(ThiSinh ts)
        {
            thisinh.Add(ts);
        }

        static string getMonThi(ThiSinh ts)
        {
            return ((ts is KhoiA) ? "Toán, Lý, Hóa" : (ts is KhoiB) ? "Toán, Hóa, Sinh" : "Văn, Sử, Địa");
        }
        static public void HienThi()
        {
            foreach (var ts in thisinh)
            {
                ts.Show();
                Console.WriteLine("Môn thi: " + getMonThi(ts));
            }
        }
        static public void ThemMoi()
        {
            Console.WriteLine("Nhập số lượng thí sinh ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin thí sinh {0}",(i+1));
                ThiSinh ts = new ThiSinh();
                Console.Write("Nhập số báo danh: ");
                int sbd = int.Parse(Console.ReadLine());
                Console.Write("Nhập họ tên: ");
                string hoten = Console.ReadLine();
                Console.Write("Địa chỉ: ");
                string diachi = Console.ReadLine();
                Console.Write("Nhập mức ưu tiên: ");
                int mucuutien = int.Parse(Console.ReadLine());
                ChonKhoi();
                int option = int.Parse(Console.ReadLine());             
                switch (option)
                {
                    case 1:                      
                        ts = new KhoiA(sbd, hoten, diachi, mucuutien);
                        break;
                    case 2:
                        ts = new KhoiB(sbd, hoten, diachi, mucuutien);
                        break;
                    case 3:
                        ts = new KhoiC(sbd, hoten, diachi, mucuutien);
                        break;
                    default:
                        Console.WriteLine("Không tồn tại");
                        break;
                }
                thisinh.Add(ts);
            }
            
        }

        static public void ChonKhoi()
        {
            Console.WriteLine("Chọn khối thi: ");
            Console.WriteLine("1.Khối A");
            Console.WriteLine("2.Khối B");
            Console.WriteLine("3.Khối C");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThemMoi();
            HienThi();
            Console.ReadKey();
        }
    }
}