using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CuDan
{
    class Nguoi
    {
        // Họ tên, Tuổi, Nghề nghiệp, số chứng minh nhân dân(duy nhất cho mỗi người).
        private string hoten;
        private int tuoi;
        private string ngheNghiep;
        private string soCMND;

        public string Hoten { get { return hoten; } set { hoten = value; } }
        public int Tuoi { get { return tuoi; } set { tuoi = value; } }
        public string NgheNghiep { get { return ngheNghiep; } set { ngheNghiep = value; } }
        public string SoCMND { 
            get { return soCMND; }
            set {
                var r = new Regex("\\d{9}");
                if (r.IsMatch(value)) soCMND = value;
                else soCMND = "";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
