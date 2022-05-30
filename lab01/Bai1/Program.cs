using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai1
{
    class Student
    {
        private int _SID;
        private string _tenSV;
        private string _khoa;
        private float _diemTB;

        public int SID { get { return _SID; } set { _SID = value; } }
        public string tenSV { get { return _tenSV; } set { _tenSV = value; } }
        public string khoa { get { return _khoa; } set { _khoa = value; } }
        public float diemTB { get { return _diemTB; } set { _diemTB = value; } }

        public void HienThi()
        {
            Console.WriteLine("Mã sinh viên " + SID);
            Console.WriteLine("Họ tên " + tenSV);
            Console.WriteLine("Khoa " + khoa);
            Console.WriteLine("Điểm trung bình " + diemTB);
        }


        class Tester
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập số sinh viên ");
                int n = int.Parse(Console.ReadLine());
                Student std = new Student();
                List<Student> students = new List<Student>();
                Console.WriteLine("========== Nhập thông tin sinh viên ==========");
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Sinh viên thứ " + i);
                    Console.Write(" Mã sinh viên ");
                    std.SID = int.Parse(Console.ReadLine());
                    Console.Write(" Họ tên ");
                    std.tenSV = Console.ReadLine();
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
        }
    }
}
