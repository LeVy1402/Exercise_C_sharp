using System;
using System.Collections;
using System.Text;


namespace StudyWithVy
{
    //Từ 58 - 70 --> chọn 5 bài và làm.
    class Program
    {
        static Random rand_170 = new Random();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sobai_170;
            Console.WriteLine("==============Menu==============");
            Console.WriteLine("Bài 59, 60, 61, 62, 65");
            Console.WriteLine("================================");
            do
            {
                Console.Write("Mời nhập số bài ");
                sobai_170 = int.Parse(Console.ReadLine());
                switch (sobai_170)
                {
                    case 59:
                        Bai59();
                        break;
                    case 60:
                        Bai60();
                        break;
                    case 61:
                        Bai61();
                        break;
                    case 62:
                        Bai62();
                        break;
                    case 65:
                        Bai65();
                        break;
                    default:
                        Console.WriteLine("Không có bài trong menu");
                        break;
                }
                Console.WriteLine("================================");
            } while (sobai_170 != 1);
            Console.ReadKey();
        }

        static void Bai59()
        {
            int n_170;
            Console.Write("Nhập năm ");
            n_170 = int.Parse(Console.ReadLine());
            String[] can_170 = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            String[] chi_170 = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.WriteLine(n_170 + " " + can_170[n_170 % 10] + " " + chi_170[n_170 % 12]);
            Console.WriteLine(n_170 + 60 + " " + can_170[n_170 % 10] + " " + chi_170[n_170 % 12]);
        }

        static bool isEquals(int[] arr1_170, int[] arr2_170)
        {
            if (arr1_170.Length != arr2_170.Length) return false;
            for (int i_170 = 0; i_170 < arr1_170.Length; i_170++)
            {
                if (arr1_170[i_170] != arr2_170[i_170]) return false;
            }
            return true;
        }

        static int[] pSuffele(int[] arr_170)
        {
            int[] tmp1_170 = new int[arr_170.Length / 2];
            int[] tmp2_170 = new int[arr_170.Length / 2];
            int k_170 = 0;
            for (int i_170 = 1, j_170 = arr_170.Length / 2; i_170 <= arr_170.Length / 2 && j_170 <= arr_170.Length - 2; i_170++, j_170++)
            {
                tmp1_170[k_170] = arr_170[i_170];
                tmp2_170[k_170] = arr_170[j_170];
                k_170++;
            }
            k_170 = 0;
            for (int i_170 = 1; i_170 <= arr_170.Length - 2; i_170 += 2)
            {
                arr_170[i_170] = tmp2_170[k_170];
                arr_170[i_170 + 1] = tmp1_170[k_170];
                k_170++;
            }
            return arr_170;
        }

        static void Bai60()
        {
            int n_170;
            do
            {
                Console.Write("Nhập vào n: ");
                n_170 = int.Parse(Console.ReadLine());
            } while (n_170 % 2 != 0);

            int[] arr_170 = new int[n_170];
            int[] tmpArr_170 = new int[arr_170.Length];

            for (int i_170 = 0; i_170 < n_170; i_170++)
            {
                arr_170[i_170] = rand_170.Next(-100, 100);
                Console.Write("{0,5}", arr_170[i_170]);
                tmpArr_170[i_170] = arr_170[i_170];
            }
            int count_170 = 1;
            tmpArr_170 = pSuffele(tmpArr_170);
            Console.WriteLine("");
            for (int i_170 = 0; i_170 < tmpArr_170.Length; i_170++)
            {
                Console.Write("{0,5}", tmpArr_170[i_170]);
            }
            while (!isEquals(arr_170, tmpArr_170))
            {
                count_170++;
                tmpArr_170 = pSuffele(tmpArr_170);
            }
            Console.WriteLine("\nSố lần: " + count_170);
        }


        static void Bai61()
        {
            int n_170, p_170 = 0;
            Console.Write("Nhập vào n: ");
            n_170 = int.Parse(Console.ReadLine());
            int[] arr_170 = new int[n_170];
            int sum_170 = 0;
            for (int i_170 = 0; i_170 < n_170; i_170++)
            {
                arr_170[i_170] = rand_170.Next(-100, 100);
                Console.Write(arr_170[i_170] + " ");
                if (arr_170[i_170] > 0)
                {
                    sum_170 += arr_170[i_170];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Tổng các số nguyên dương có trong mảng " + sum_170);
            do
            {
                Console.Write("Nhập p [0, {0}] ", n_170 - 1);
                p_170 = int.Parse(Console.ReadLine());
            } while (p_170 < 0 || p_170 > n_170 - 1);
            for (int i_170 = p_170 + 1; i_170 < n_170; i_170++)
            {
                arr_170[i_170 - 1] = arr_170[i_170];
            }
            n_170--;
            for (int i_170 = 0; i_170 < n_170; i_170++)
            {
                Console.Write(arr_170[i_170] + " ");
            }
            Console.WriteLine(" ");
        }

        static int __gcd(int a_170, int b_170)
        {
            if (a_170 == 0 || b_170 == 0)
                return 0;

            if (a_170 == b_170)
                return a_170;

            if (a_170 > b_170)
                return __gcd(a_170 - b_170, b_170);

            return __gcd(a_170, b_170 - a_170);
        }

        static void Bai62()
        {
            int n_170;
            do
            {
                Console.Write("Nhập n_170 [1, 99]: ");
                n_170 = int.Parse(Console.ReadLine());
            } while (n_170 < 1 || n_170 > 99);

            int[] arr_107 = new int[n_170];
            int sumOdd_170 = 0, sumEven_170 = 0;
            for (int i_170 = 0; i_170 < n_170; i_170++)
            {
                arr_107[i_170] = rand_170.Next(10, 20);
                Console.Write(arr_107[i_170] + " ");
                int pos_170 = i_170 + 1;
                if (pos_170 % 2 == 0 && arr_107[i_170] % 2 == 1)
                {
                    sumEven_170 += arr_107[i_170];
                }
                if (pos_170 % 2 == 1 && arr_107[i_170] % 2 == 0)
                {
                    sumOdd_170 += arr_107[i_170];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Tổng các số chẵn ở vị trí lẻ ({0}) " + (sumEven_170 == sumOdd_170 ? "" : "không") + " bằng tổng các số lẻ ở vị trí chẵn ({1})", sumEven_170, sumOdd_170);
            for (int i_170 = 0; i_170 < n_170 - 1; i_170++)
            {
                if (__gcd(arr_107[i_170], arr_107[i_170 + 1]) == 1)
                    Console.WriteLine("({0}, {1})", arr_107[i_170], arr_107[i_170 + 1]);
            }
        }

        static void Bai65()
        {
            int n_170;
            do
            {
                Console.Write("Nhập n[1, 99]: "); n_170 = int.Parse(Console.ReadLine());
            } while (n_170 < 1 || n_170 > 99);

            int[] arr_170 = new int[n_170];
            Console.Write("Nhập 10 phần tử: "); string[] str_170 = Console.ReadLine().Split(' ');

            var unique_170 = new ArrayList();
            int result_170 = 0, count_170 = 0;
            for (int i_170 = 0; i_170 < arr_170.Length; i_170++)
            {
                arr_170[i_170] = int.Parse(str_170[i_170]);
                if (arr_170[i_170] % 2 != 0 && arr_170[i_170] < 0)
                {
                    result_170 += arr_170[i_170];
                    count_170++;
                }
                if (unique_170.IndexOf(arr_170[i_170]) == -1)
                {
                    unique_170.Add(arr_170[i_170]);
                }
            }

            Console.WriteLine("Trung bình cộng số nguyên âm lẻ: {0:0.00}", (result_170 * 1.0 / (count_170 == 0 ? 1 : count_170)));
            foreach (int i_170 in unique_170)
            {
                Console.Write(i_170 + " ");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}