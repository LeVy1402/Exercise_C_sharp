using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class Student
    {
        private int _SID;
        private string _tenSV;
        private string _khoa;
        private float _diemTB;

        public int getSID()
        {
            return this._SID;
        }

        public void setSID(int value)
        {
            this._SID = value;
        }

        public string getTenSV()
        {
            return this._tenSV;
        }

        public void setTenSV(string value)
        {
            this._tenSV = value;
        } 
        public string getKhoa()
        {
            return this._khoa;
        }
        public void setKhoa(string value)
        {
            this._khoa = value;
        }
        public float getDiemTB()
        {
            return this._diemTB;
        }
        public void setDiemTB(float value)
        {
            this._diemTB = value;
        }
        public void HienThi()
        {
            Console.WriteLine("Mã sinh viên " + _SID);
            Console.WriteLine("Họ tên " + _tenSV);
            Console.WriteLine("Khoa " + _khoa);
            Console.WriteLine("Điểm trung bình " + _diemTB);
        }      

        class Tester
        {                                               
            static public Student Nhap1()
            {
                Student std = new Student();
                Console.Write(" Mã sinh viên ");
                std.setSID(int.Parse(Console.ReadLine()));
                Console.Write(" Họ tên ");
                std.setTenSV(Console.ReadLine());
                Console.Write(" Khoa ");
                std.setKhoa(Console.ReadLine());
                Console.Write(" Điểm trung bình ");
                std.setDiemTB(float.Parse(Console.ReadLine()));
                return std;
            }
           
            static public void HienThiDS(List<Student> list)
            {
                Console.WriteLine("========== Hiển thị thông tin sinh viên ==========");
                foreach(Student student in list)
                {
                    student.HienThi();
                }
                Console.ReadKey();
            }

            static public List<Student> NhapDS(int n)
            {
                List<Student> students = new List<Student>();
                Console.WriteLine("========== Nhập thông tin sinh viên ==========");
                for (int i = 1; i <= n; i++)
                {
                    Student student = Nhap1();
                    students.Add(student);
                }
                return students;
            }

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập số sinh viên ");
                int n = int.Parse(Console.ReadLine());
                List<Student> students = NhapDS(n);
                HienThiDS(students);
            }
        }
    }
}
