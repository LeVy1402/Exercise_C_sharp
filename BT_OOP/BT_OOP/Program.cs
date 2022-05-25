using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    enum eGioiTinh
    {
        Nam,
        Nu,
        Khac
    }
    class CanBo
    {
        //Họ tên, tuổi, giới tính(name, nữ, khác), địa chỉ.
        private string hoTen;
        private int tuoi;
        private eGioiTinh gioiTinh;
        private string diaChi;

        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public int Tuoi { get { return tuoi; } set { tuoi = value; } }
        public eGioiTinh GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } } 
        
        public CanBo(string name, int age, eGioiTinh gender, string address)
        {
            hoTen = name;
            tuoi = age;
            gioiTinh = gender;
            diaChi = address;
        }
    }

    class CongNhan : CanBo
    {
        protected int bac;

        public CongNhan(string name, int age, eGioiTinh gender, string address, int level):base(name, age, gender, address)
        {
            bac = level;
        }

    }

    class KySu : CanBo
    {
        protected string ngangDaoTao;

        public KySu(string name, int age, eGioiTinh gender, string address, string industry) : base(name, age, gender, address)
        {
            ngangDaoTao = industry;
        }

    }

    class NhanVien : CanBo
    {
        protected string congViec;

        public NhanVien(string name, int age, eGioiTinh gender, string address, string work) : base(name, age, gender, address)
        {
            congViec = work;
        }

    }

    class QLCB
    {
        //Thêm mới cán bộ.
        //Tìm kiếm theo họ tên.
        //Hiện thị thông tin về danh sách các cán bộ.
        //Thoát khỏi chương trình.

        List<CanBo> list;
        public QLCB()
        {
            list = new List<CanBo>();
        }

        void addCanBo(CanBo canBo)
        {
            list.Add(canBo);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("========Thêm mới cán bộ========");
            Console.WriteLine("a. Nhân viên: ");
            Console.WriteLine("b. Kỹ sư: ");
            Console.WriteLine("c. Công nhân: ");
            Console.Write("Chọn loại cán bộ: (Input a b c) ");
            string c = Console.ReadLine();
            
            if (c == "a")
            {

            }
        }
    }
}
