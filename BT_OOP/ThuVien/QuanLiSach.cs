using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    class TaiLieu
    {
        private string maTaiLieu;
        public string MaTaiLieu { get { return maTaiLieu; } set { maTaiLieu = value; } }
        public string Name { get; set; }
        public string Nxb { get; set; }
        public int soBanPhatHanh { set; get; }

        virtual public void Nhap()
        {
            Console.Write("Nhập vào mã tài liệu: "); MaTaiLieu = Console.ReadLine();
            Console.Write("Nhập vào tên tài liệu: "); Name = Console.ReadLine();
            Console.Write("Nhập vào nhà xuất bản: "); Nxb = Console.ReadLine();
            Console.Write("Nhập vào số bản phát hành: "); soBanPhatHanh = int.Parse(Console.ReadLine());

        }

        virtual public void HienThi()
        {
            Console.WriteLine("Mã tài liệu: {0}", MaTaiLieu);
            Console.WriteLine("Tên tài liệu: {0}", Name);
            Console.WriteLine("Nhà xuất bản: {0}", Nxb);
            Console.WriteLine("Số bản phát hành: {0}", soBanPhatHanh);

        }
    }

    class Sach : TaiLieu
    {
        public string tenTacGia { get; set; }
        public int soTrang { get; set; }
        override
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập vào tên tác giả: "); tenTacGia = Console.ReadLine();
            Console.Write("Nhập vào số trang: "); soTrang = int.Parse(Console.ReadLine());
        }
        override
        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Tên tác giả: {0}", tenTacGia);
            Console.WriteLine("Số trang: {0}", soTrang);

        }
    }

    class TapChi : TaiLieu
    {
        public int thangPhatHanh { get; set; }
        public int soPhatHanh { get; set; }

        override
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập vào số phát hành: "); soPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào tháng phát hành: "); thangPhatHanh = int.Parse(Console.ReadLine());
        }

        override
        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Số phát hành: {0}", soPhatHanh);
            Console.WriteLine("Tháng phát hành: {0}", thangPhatHanh);

        }
    }

    class Bao : TaiLieu
    {
        public int ngayPhatHanh { get; set; }

        override
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập vào ngày phát hành: "); ngayPhatHanh = int.Parse(Console.ReadLine());
        }
        override
        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Ngày phát hành: {0}", ngayPhatHanh);

        }
    }
    class QuanLySach
    {
        static List<TaiLieu> arr = new List<TaiLieu>();

        static void buildMenu()
        {
            Console.WriteLine("1. Thêm mới tài liệu");
            Console.WriteLine("2. Xóa tài liệu theo ID");
            Console.WriteLine("3. Hiển thị thông tin về tài liệu");
            Console.WriteLine("4. Tìm kiếm tài liệu theo loại");
            Console.WriteLine("5. Thoát");
        }

        static void buildModel()
        {
            Console.Clear();
            Console.WriteLine("============== Chọn loại tài liệu ==============");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
        }



        static void run(int option)
        {
            switch (option)
            {
                case 1:
                    int model;
                    buildModel();
                    Console.Write("Loại tài liệu: ");
                    model = int.Parse(Console.ReadLine());
                    TaiLieu taiLieu = null;
                    Console.Clear();
                    Console.WriteLine("============== Nhập thông tin ==============");
                    switch (model)
                    {
                        case 1:
                            Console.WriteLine("Tạo mới sách: ");
                            taiLieu = new Sach();
                            break;
                        case 2:
                            Console.WriteLine("Tạo mới tạp chí: ");
                            taiLieu = new TapChi();
                            break;
                        case 3:
                            Console.WriteLine("Tạo mới báo: ");
                            taiLieu = new Bao();
                            break;
                    }
                    taiLieu.Nhap();
                    var isUnique = arr.FirstOrDefault(item => item.MaTaiLieu == taiLieu.MaTaiLieu) == null ? true : false;
                    if (isUnique)
                    {
                        arr.Add(taiLieu);
                    }
                    else
                    {
                        Console.WriteLine("Mã tài liệu đã tồn tại, vui lòng nhập lại");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("============== Xóa tài liệu ==============");
                    string id = "";
                    Console.Write("Nhập vào mã tài liệu bạn muốn xóa: "); id = Console.ReadLine();
                    if (String.IsNullOrEmpty(id))
                    {
                        Console.WriteLine("Hãy nhập vào id muốn xóa!!");
                    }
                    else
                    {
                        arr.Remove(arr.FirstOrDefault(item => item.MaTaiLieu == id));
                        Console.WriteLine("Thao tác thành công!!");
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("Nhập vào mã tài liệu bạn muốn hiển thị: "); id = Console.ReadLine();
                    if (String.IsNullOrEmpty(id))
                    {
                        Console.WriteLine("Hãy nhập vào id hiển thị!!");
                    }
                    var result = arr.FirstOrDefault(item => item.MaTaiLieu == id);
                    if (result == null)
                        Console.WriteLine("Không tìm thấy tài liệu có mã {0}", id);
                    else
                    {
                        Console.WriteLine("============== Kết quả tìm kiếm ==============");
                        result.HienThi();
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    buildModel();
                    var result2 = arr.Where(item => item is Sach);
                    switch (Console.ReadLine())
                    {
                        case "2":
                            result2 = arr.Where(item => item is TapChi);
                            break;
                        case "3":
                            result2 = arr.Where(item => item is Bao);
                            break;
                        case "1": break;
                    }
                    Console.WriteLine("============== Kết quả tìm kiếm ==============");
                    foreach (var taiLieu1 in result2)
                    {
                        taiLieu1.HienThi();
                        Console.WriteLine("");
                    }
                    Console.ReadKey();
                    break;
                case -1: break;
            }
        }
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("============== Chọn hành động ==============");
                buildMenu();
                Console.Write("Chọn chức năng: ");
                int option = -1;
                int.TryParse(Console.ReadLine(), out option);
                if (option == 5) { return; }
                run(option);
            }
        }
    }
}
