using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Diem_Danh_10_05
{
    class Program
    {
        static int GTLN(int[] mang_170)
        {
            int max_170 = mang_170[0];
            for (int i = 0; i < mang_170.Length; i++)
            {
                if (max_170 < mang_170[i])
                    max_170 = mang_170[i];
            }
            return max_170;
        }

        static int GTNN(int[] mang_170)
        {
            int min_170 = mang_170[0];
            for (int i = 0; i < mang_170.Length; i++)
            {
                if (min_170 > mang_170[i])
                    min_170 = mang_170[i];
            }
            return min_170;
        }
        static void XuatHienNN(int[] mang_170)
        {
            int n = 10;
            int[] mangDem = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int dem = 1;
                mangDem[i] = dem;
                for (int j = i + 1; j < n; j++)
                {
                    if (mang_170[i] == mang_170[j])
                    {
                        mang_170[i] = ++dem;
                        for (int k = j; k < 10; k++)
                        {
                            mang_170[k] = mang_170[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            int max = 0, vi_tri = 0;
            for (int i = 0; i < n; i++)
            {           
                    if (mangDem[i] > max)
                    {
                        max = mangDem[i];
                        vi_tri = i;
                    }
            }
            Console.WriteLine("\nPhan tu thu {0} trong mang xuat hien nhieu nhat ,cu the la {1} lan.\n", vi_tri + 1, max);
        }

        static void TangDan(int[] a)
        {
            int tmp;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[j] < a[i])
                    {                        
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            XuatMang(a);
        }
        static void GiamDan(int[] a)
        {
            int tmp;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[i] < a[j])
                    {                   
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            XuatMang(a);
        }

        static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Gia tri phan tu thu {0} la: {1}", i, a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] mang = new int[10];
          
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhập số thứ {0}:", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            XuatMang(mang);
            Console.WriteLine("\n\n Số lớn nhất trong mảng là: {0}", GTLN(mang));
            Console.WriteLine("\n\n Số nhỏ nhất trong mảng là: {0}", GTNN(mang));
            XuatHienNN(mang);
            TangDan(mang);
            GiamDan(mang);
            Console.ReadKey();
        }
    }
}
