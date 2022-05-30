using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Staff
    {
        private string _hoTen;
        private int _namSinh;
        private string _bangCap;

        public string hoTen { get { return _hoTen; } set { _hoTen = value; } }
        public int namSinh { get { return _namSinh; } set { _namSinh = value; } }
        public string bangCap
        {
            get { return _bangCap; }
            set { _bangCap = value; }
        }  
        
        virtual public void Nhap()
        {
            Console.Write("Họ tên "); hoTen = Console.ReadLine();
            Console.Write("Năm sinh "); namSinh = int.Parse(Console.ReadLine());
            Console.Write("Bằng cấp "); bangCap = Console.ReadLine();
        }

        virtual public void Xuat()
        {
            Console.WriteLine(" Họ tên " + hoTen);
            Console.WriteLine(" Năm sinh " + namSinh);
            Console.WriteLine(" Bằng cấp " + bangCap);
        }
    }
    class NhaQuanLy : Staff
    {
        private string _chucVu;
        private int _soNgayCongTrongThang;
        private int _bacLuong;

        public string chucVu { get { return _chucVu; } set { _chucVu = value; } }
        public int soNgayCongTrongThang { get { return _soNgayCongTrongThang; } set { _soNgayCongTrongThang = value; } }
        public int bacLuong
        {
            get { return _bacLuong; }
            set { _bacLuong = value; }

        }
        override
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Chức vụ "); chucVu = Console.ReadLine();
            Console.Write("Số ngày công trong tháng "); soNgayCongTrongThang = int.Parse(Console.ReadLine());
            Console.Write("Bậc lương "); bacLuong = int.Parse(Console.ReadLine());
        }
        override
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine(" Chức vụ " + chucVu);
            Console.WriteLine(" Số ngày công trong tháng " + soNgayCongTrongThang);
            Console.WriteLine(" Bậc lương " + bacLuong);
        }
    }
    class NhaKhoaHoc : NhaQuanLy
    {        
        private int _soBaiBao;  
       
        public int soBaibao { get { return _soBaiBao; } set { _soBaiBao = value; }}
        override
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Số bài báo đã công bố "); soBaibao = int.Parse(Console.ReadLine());           
        }
        override
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine(" Số bài báo đã công bố " + soBaibao);         
        }
    }
    class NhanVien : Staff
    {
        private float _luongtrongthang;
        public float luongtrongthang
        {
            get { return _luongtrongthang; }
            set { if (_luongtrongthang != value) { _luongtrongthang = value; } }
        }
        override
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Lương trong tháng "); luongtrongthang = float.Parse(Console.ReadLine());
        }
        override
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine(" Lương trong tháng " + luongtrongthang);
        }
    }

    internal class Program
    {
        static void buildModel()
        {
            Console.WriteLine();
            Console.WriteLine("1. Nhà khoa học");
            Console.WriteLine("2. Nhà quản lí");
            Console.WriteLine("3. Nhân viên văn phòng thí nghiệm");           
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Staff staff = new Staff();
            List<Staff> staffs = new List<Staff>();
            Console.Write("Nhập số lượng nhân viên ");
            int soLuong = int.Parse(Console.ReadLine());
            for(int i=1; i<=soLuong; i++)
            {
                buildModel();
                Console.Write("Chọn đối tượng ");           
                int model = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("======= Nhập thông tin nhân viên thứ {0} =======", i);
                switch (model)
                {
                    case 1:
                        Console.WriteLine("Tạo mới nhà khoa học");
                        staff = new NhaKhoaHoc();
                        break;
                    case 2:
                        Console.WriteLine("Tạo mới nhà quản lí");
                        staff = new NhaQuanLy();
                        break;
                    case 3:
                        Console.WriteLine("Tạo mới nhân viên phòng thí nghiệm");
                        staff = new NhanVien();
                        break;
                }               
                staff.Nhap();
                staffs.Add(staff);
            }
            Console.WriteLine("========== Hiển thị thông tin nhân viên ==========");
            for (int i = 0; i < soLuong; i++)
            {
                staffs.ElementAt(i).Xuat();
                Console.WriteLine();
            }
            Console.WriteLine("========== Tổng lương chi trả ==========");
            int luongQuanLy = 0, luongNKH = 0;
            float luongNhanVien = 0f; //f = float

            for (int i = 0; i < soLuong; i++)
            {
                var staff1 = staffs.ElementAt(i);
                if (staff1 is NhanVien)
                {
                    luongNhanVien += (staff1 as NhanVien).luongtrongthang;
                }
                else if(staff1 is NhaKhoaHoc) {
                    luongQuanLy += (staff1 as NhaKhoaHoc).bacLuong * (staff1 as NhaKhoaHoc).soNgayCongTrongThang;
                }
                else
                {
                    luongNKH += (staff1 as NhaQuanLy).bacLuong * (staff1 as NhaQuanLy).soNgayCongTrongThang;
                }
            }
            Console.WriteLine(String.Format("Lương nhân viên: {0} \nLương quản lý: {1}\nLương nhà khoa học: {2}", luongNhanVien, luongQuanLy, luongNKH));
            Console.ReadKey();
        }
    }

}
