using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai3
{
    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Student : People
    {
        private string _khoa;
        private float _diemTB;
        public string khoa { get { return _khoa; } set { _khoa = value; } }
        public float diemTB { get { return _diemTB; } set { _diemTB = value; } }

        public void HienThi()
        {
            Console.WriteLine("Mã sinh viên " + Id);
            Console.WriteLine("Họ tên " + Name);
            Console.WriteLine("Khoa " + khoa);
            Console.WriteLine("Điểm trung bình " + diemTB);
        }

        public static void sdList(int n)
        {
            Student std = new Student();
            List<Student> students = new List<Student>();
            Console.WriteLine("========== Nhập thông tin sinh viên ==========");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Sinh viên thứ " + i);
                Console.Write(" Mã sinh viên ");
                std.Id = int.Parse(Console.ReadLine());
                Console.Write(" Họ tên ");
                std.Name = Console.ReadLine();
                Console.Write(" Khoa ");
                std.khoa = Console.ReadLine();
                Console.Write(" Điểm trung bình ");
                std.diemTB = float.Parse(Console.ReadLine());
                students.Add(std);
                std = new Student();
            }
            Console.WriteLine("========== Hiển thị thông tin sinh viên ==========");
            for (int i = 0; i < n; i++)
            {
                students.ElementAt(i).HienThi();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void sdArrList(int n)
        {
            Student std = new Student();
            ArrayList students = new ArrayList();
            Console.WriteLine("========== Nhập thông tin sinh viên ==========");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Sinh viên thứ " + i);
                Console.Write(" Mã sinh viên ");
                std.Id = int.Parse(Console.ReadLine());
                Console.Write(" Họ tên ");
                std.Name = Console.ReadLine();
                Console.Write(" Khoa ");
                std.khoa = Console.ReadLine();
                Console.Write(" Điểm trung bình ");
                std.diemTB = float.Parse(Console.ReadLine());
                students.Add(std);
                std = new Student();
            }
            Console.WriteLine("========== Hiển thị thông tin sinh viên ==========");
            foreach(Student student in students)
            {
                student.HienThi();
                Console.WriteLine();
            }               
            Console.ReadKey();
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập số sinh viên ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Nhập kiểu 1.List 2.Arraylist ");
                int kieu = int.Parse(Console.ReadLine());
                switch (kieu)
                {
                    case 1:
                        sdList(n);
                        break;
                    case 2:
                        sdArrList(n);
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại");
                        break;
                }

            }
        }
    }
}
