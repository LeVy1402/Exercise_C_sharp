using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Struct
{
    class Program
    {      
        enum Khoa
        {
            Dien,
            Cong_nghe_so,
            Hoa,
            Co,
            Su_pham
        }
        enum GioiTinh
        {
            Nam, 
            Nu
        }
        struct SinhVien
        {
            public int MSV_170;
            public Khoa khoa_170;
            public GioiTinh GioiTinh_170;
            public string HoTen_170;
            public double DiemToan_170;
            public double DiemLy_170;
            public double DiemLTC_170;
        }
        static void NhapThongTinSinhVien(out SinhVien SV170)
        {
            Console.Write("Mã sinh viên: ");
            SV170.MSV_170 = int.Parse(Console.ReadLine());
            Console.Write("Họ tên: ");
            SV170.HoTen_170 = Console.ReadLine();
            do
            {
                Console.Write("Giới tính: ");
            } while (!Enum.TryParse(Console.ReadLine(), out SV170.GioiTinh_170));
            do
            {
                Console.Write("Khoa: ");
            } while (!Enum.TryParse(Console.ReadLine(), out SV170.khoa_170));
            Console.Write(" Điểm toán rời rạc: ");
            SV170.DiemToan_170 = double.Parse(Console.ReadLine());
            Console.Write(" Điểm vật lí cơ - quang: ");
            SV170.DiemLy_170 = double.Parse(Console.ReadLine());
            Console.Write(" Điểm lập trình C: ");
            SV170.DiemLTC_170 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ============================ ");
        }

        static void XuatThongTin(SinhVien SV)
        {
            Console.WriteLine(" Mã sinh viên: " + SV.MSV_170);
            Console.WriteLine(" Họ tên: " + SV.HoTen_170);
            Console.WriteLine(" Giới tính: " + SV.GioiTinh_170);
            Console.WriteLine(" Khoa: " + SV.khoa_170.ToString());
            Console.WriteLine(" Điểm toán rời rạc: " + SV.DiemToan_170);
            Console.WriteLine(" Điểm vật lí cơ - quang: " + SV.DiemLy_170);
            Console.WriteLine(" Điểm lập trình C: " + SV.DiemLTC_170);
        }
        static double DiemTB_170(SinhVien SV_170)
        {
            return (SV_170.DiemToan_170 + SV_170.DiemLy_170 + SV_170.DiemLTC_170) / 3;
        }      

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khởi tạo list n sv
            SinhVien[] svList_170;

            Console.Write("Nhập vào số sinh viên: ");
            int n_170 = int.Parse(Console.ReadLine());
            svList_170 = new SinhVien[n_170];

            for (int i_170 = 0; i_170 < n_170; i_170++)
            {
                NhapThongTinSinhVien(out svList_170[i_170]);
            }
            
            //foreach duyet sv
            int j_170 = 1;
            foreach (SinhVien s_170 in svList_170)
            {
                Console.WriteLine("Sinh viên thứ {0}:", j_170++);
                XuatThongTin(s_170);
            }
            Console.WriteLine(" ============================ ");
            Console.Write("Nhập vào tên sinh viên để tìm kiếm: ");
            String name_170 = Console.ReadLine();
            foreach (SinhVien s_170 in svList_170)
            {
                if (name_170 == s_170.HoTen_170)
                {
                    XuatThongTin(s_170);
                    Console.WriteLine("Điểm trung bình: {0:0.00}", DiemTB_170(s_170));
                }
            }
            Console.ReadLine();
        }
    }
}
