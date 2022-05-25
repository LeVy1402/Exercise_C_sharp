using System;
using System.Collections;
using System.Text;


namespace Ebook250
{
    //1, 2, 4, 7, 12, 13, 15, 22, 23, 33, 36, 59, 60, 61, 62, 65
    
    class Program
    {
        static Random rand_170 = new Random();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sobai_170;
            do
            {
                Console.Write("Mời nhập số bài ");
                sobai_170 = int.Parse(Console.ReadLine());
                switch (sobai_170)
                {
                    case 1:
                        Bai1();
                        break;
                    case 2:
                        Bai2();
                        break;
                    case 4:
                        Bai4();
                        break;
                    case 7:
                        Bai7();
                        break;
                    case 12:
                        Bai12();
                        break;
                    case 13:
                        Bai13();
                        break;
                    case 15:
                        Bai15();
                        break;
                    case 22:
                        Bai22();
                        break;
                    case 23:
                        Bai23();
                        break;
                    case 33:
                        Bai33();
                        break;
                    case 36:
                        Bai36();
                        break;
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
        //Bài 1: Nhập vào diện tích S của một mặt cầu.Tính thể tích V của hình cầu này.
        static void Bai1()
        {
            float S_170, R_170, V_170;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập diện tích S ");
            S_170 = float.Parse(Console.ReadLine());
            R_170 = (float)Math.Sqrt(S_170 / (4 * Math.PI));
            V_170 = (float)(4 * Math.PI * Math.Pow(R_170, 3) / 3);
            Console.WriteLine("Thể tích V = " + V_170);
        }
        //Bài 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB
        static void Bai2()
        {
            float xA_170, yA_170, xB_170, yB_170;
            float AB_170 = 0;
            Console.Write("A(xA, yA)? ");
            string[] toadoA_170 = Console.ReadLine().Split(' ');
            xA_170 = float.Parse(toadoA_170[0]);
            yA_170 = float.Parse(toadoA_170[1]);
            Console.Write("B(xB, yB)? ");
            string[] toadoB_170 = Console.ReadLine().Split(' ');
            xB_170 = float.Parse(toadoB_170[0]);
            yB_170 = float.Parse(toadoB_170[1]);
            AB_170 = (float)(Math.Sqrt(Math.Pow(xB_170 - xA_170, 2) + Math.Pow(yB_170 - yA_170, 2)));
            Console.WriteLine("|AB| =  " + AB_170);
        }
        /*Bài 4: Viết chương trình nhập vào ba số thực là ba cạnh của một tam giác.Kiểm tra
        ba cạnh được nhập có hợp lệ hay không.Nếu hợp lệ, hãy cho biết loại tam giác và
        tính diện tích tam giác đó.*/
        static void Bai4()
        {
            int canhA_170, canhB_170, canhC_170;
            Console.Write("Nhập 3 cạnh tam giác ");
            string[] canhTamGiac_170 = Console.ReadLine().Split(' ');
            canhA_170 = int.Parse(canhTamGiac_170[0]);
            canhB_170 = int.Parse(canhTamGiac_170[1]);
            canhC_170 = int.Parse(canhTamGiac_170[2]);
            if (canhA_170 > 0 && canhB_170 > 0 && canhC_170 > 0 && canhA_170 + canhB_170 > canhC_170 && canhA_170 + canhC_170 > canhB_170 && canhB_170 + canhC_170 > canhA_170)
            {
                int f_170 = 0;
                if (canhA_170 == canhB_170 || canhB_170 == canhC_170 || canhB_170 == canhC_170)
                    f_170 += 1;
                if (canhA_170 == canhB_170 && canhB_170 == canhC_170)
                    f_170 += 1;
                if (canhA_170 * canhA_170 + canhB_170 * canhB_170 == canhC_170 * canhC_170
                    || canhA_170 * canhA_170 + canhC_170 * canhC_170 == canhB_170 * canhB_170
                    || canhB_170 * canhB_170 + canhC_170 * canhC_170 == canhA_170 * canhA_170)
                    f_170 += 3;
                switch (f_170)
                {
                    case 0:
                        Console.WriteLine("Tam giác thường");
                        break;
                    case 1:
                        Console.WriteLine("Tam giác cân");
                        break;
                    case 2:
                        Console.WriteLine("Tam giác đều");
                        break;
                    case 3:
                        Console.WriteLine("Tam giác vuông");
                        break;
                    case 4:
                        Console.WriteLine("Tam giác cân");
                        break;
                }
                float p_170 = (canhA_170 + canhB_170 + canhC_170) / 2;
                float S_170 = (float)Math.Sqrt(p_170 * (p_170 - canhA_170) * (p_170 - canhB_170) * (p_170 - canhC_170));
                Console.WriteLine("Diện tích S = " + S_170);
            }
            else
            {
                Console.WriteLine("Không hợp lệ");
            }

        }
        /*Bài 7: Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím).
        Xét tất cả các trường hợp có thể.*/
        static void Bai7()
        {
            float a_170, b_170;
            Console.WriteLine("Nhập a, b: ");
            string[] so_170 = Console.ReadLine().Split(' ');
            a_170 = float.Parse(so_170[0]);
            b_170 = float.Parse(so_170[1]);
            if (a_170 == 0)
                if (b_170 == 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                else
                    Console.WriteLine("Phương trình vô số nghiệm");
            else
                Console.WriteLine("Phương trình có nghiệm " + -b_170 / a_170);

        }
        //Bài 12: Viết chương trình giải hệ phương trình 2 ẩn:
        static void Bai12()
        {
            float a1_170, b1_170, c1_170, a2_170, b2_170, c2_170, dx_170, dy_170, d_170;
            Console.Write("Nhập a1, b1, c1 ");
            string[] mot_170 = Console.ReadLine().Split(' ');
            a1_170 = int.Parse(mot_170[0]);
            b1_170 = int.Parse(mot_170[1]);
            c1_170 = int.Parse(mot_170[2]);
            Console.Write("Nhập a2, b2, c2 ");
            string[] hai_170 = Console.ReadLine().Split(' ');
            a2_170 = int.Parse(hai_170[0]);
            b2_170 = int.Parse(hai_170[1]);
            c2_170 = int.Parse(hai_170[2]);

            d_170 = (a1_170 * b2_170 - a2_170 * b1_170);
            dx_170 = (c1_170 * b2_170 - c2_170 * b1_170);
            dy_170 = (a1_170 * c2_170 - a2_170 * c1_170);
            if (d_170 == 0)
            {
                if (dx_170 + dy_170 == 0)
                    Console.Write("Vô số nghiệm");
                else
                    Console.Write("Vô nghiệm");
            }
            else
            {
                Console.WriteLine("x = " + dx_170 / d_170);
                Console.WriteLine("y = " + dy_170 / d_170);
            }
        }
        /*Bài 13: Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập
        có hợp lệ hay không.Tính thứ trong tuần của ngày đó.*/
        static void Bai13()
        {
            int d_170, m_170, y_170, top_170 = 0, dayofweek_170 = 0;
            Console.Write("Nhập ngày thàng và năm ");
            String[] so_170 = Console.ReadLine().Split(' ');
            d_170 = int.Parse(so_170[0]);
            m_170 = int.Parse(so_170[1]);
            y_170 = int.Parse(so_170[2]);
            if (m_170 < 1 || m_170 > 12)
                Console.WriteLine("Tháng không hợp lệ");
            switch (m_170)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    top_170 = 30;
                    break;
                case 2:
                    if ((y_170 % 4 == 0 && y_170 % 100 != 0) || y_170 % 400 == 0)
                        top_170 = 29;
                    else top_170 = 28;
                    break;
                default:
                    top_170 = 31;
                    break;
            }
            if (d_170 < 1 || d_170 > top_170)
                Console.WriteLine("Số ngày không hợp lệ");
            Console.WriteLine("Hợp lệ");
            int a_170 = (14 - m_170) / 12;
            y_170 -= a_170;
            m_170 = m_170 + 12 * a_170 - 2;
            dayofweek_170 = (d_170 + y_170 + y_170 / 4 - y_170 / 100 + y_170 / 400 + (31 * m_170) / 12) % 7;
            if ((int)dayofweek_170 == 0)
                Console.WriteLine("Chủ nhật");
            else
                Console.WriteLine("Thứ " + (int)(dayofweek_170 + 1));
        }
        /*Bài 15: Viết chương trình nhập vào ngày, tháng, năm (giả sử nhập đúng, không cần kiểm tra hợp lệ). 
        Tìm xem ngày đó là ngày thứ bao nhiêu trong năm.*/
        static void Bai15()
        {
            int d_170, m_170, y_170, s_170, i_170;
            Console.Write("Nhập ngày thàng và năm ");
            String[] so_170 = Console.ReadLine().Split(' ');
            d_170 = int.Parse(so_170[0]);
            m_170 = int.Parse(so_170[1]);
            y_170 = int.Parse(so_170[2]);
            s_170 = d_170;
            for (i_170 = 1; i_170 < m_170; ++i_170)
            {
                switch (i_170)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        s_170 += 30;
                        break;
                    case 2:
                        if ((y_170 % 4 == 0 && y_170 % 100 != 0) || y_170 % 400 == 0)
                            s_170 += 29;
                        else s_170 += 28;
                        break;
                    default:
                        s_170 += 31;
                        break;
                }
            }
            Console.WriteLine("Ngày thứ " + s_170);
        }
        /*Bài 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n(n nhập từ bàn phím).*/
        static void Bai22()
        {
            int n_170, i_170, count_170, sum_170;
            Console.Write("Mời nhập số ");
            n_170 = int.Parse(Console.ReadLine());
            Console.Write("Các ước số ");
            count_170 = 0;
            sum_170 = 0;
            for (i_170 = 1; i_170 <= n_170; ++i_170)
            {
                if (n_170 % i_170 == 0)
                {
                    Console.Write(i_170 + " ");
                    count_170++;
                    sum_170 += i_170;
                }
            }
            Console.WriteLine("\nCó " + count_170 + " ước số, có tổng là " + sum_170);
        }
        /*Bài 23: Viết chương trình tìm các số hoàn hảo(perfect number) nhỏ hơn một số
        nguyên dương n cho trước.Biết số hoàn hảo là số nguyên dương, bằng tổng các ước
        số thực sự của nó(ví dụ: 28 = 14 + 7 + 4 + 2 + 1)*/
        static void Bai23()
        {
            int n_170, i_170, j_170, sum_170;
            Console.Write("Nhập n ");
            n_170 = int.Parse(Console.ReadLine());
            Console.WriteLine("Các số hoàn hảo nhỏ hơn " + n_170);
            for (i_170 = 1; i_170 < n_170; ++i_170)
            {
                sum_170 = 0;
                for (j_170 = 1; sum_170 <= i_170 && j_170 < i_170; ++j_170)
                    if (i_170 % j_170 == 0)
                        sum_170 += j_170;
                if (sum_170 == i_170)
                    Console.WriteLine(i_170);
            }

        }
        /*Bài 33: Số tự nhiên có n chữ số là một số Armstrong(còn gọi là narcissistic numbers
        hoặc pluperfect digital invariants - PPDI) nếu tổng các lũy thừa bậc n của các chữ số
        của nó bằng chính nó.Hãy tìm tất cả các số Armstrong có 3, 4 chữ số.
        Ví dụ: 153 là số Armstrong có 3 chữ số vì: 13 + 53 + 33 = 153*/
        static void Bai33()
        {
            int i_170, j_170, s_170;
            Console.WriteLine("Số Amstrong có 3, 4 chữ số ");
            for (i_170 = 100; i_170 < 9999; ++i_170)
            {
                for (s_170 = 0, j_170 = i_170; s_170 <= i_170 && j_170 > 0; j_170 /= 10)
                    s_170 += (int)Math.Pow(j_170 % 10, i_170 < 1000 ? 3 : 4);
                if (i_170 == s_170)
                    Console.Write(i_170 + " ");
            }
            Console.WriteLine("");
        }
        //Bài 36: Viết chương trình in ra n số nguyên tố đầu tiên(n nhập từ bàn phím)
        static void Bai36()
        {
            int n_170, k_170, i_170, count_170;
            Console.Write("Nhập n ");
            n_170 = int.Parse(Console.ReadLine());
            k_170 = 2;
            count_170 = 0;
            while (count_170 < n_170)
            {
                for (i_170 = 2; i_170 <= (int)Math.Sqrt(k_170); i_170++)
                {
                    if (k_170 == 2 || k_170 == 3) break;
                    if (k_170 % i_170 == 0) goto _continue;
                }
                Console.Write(k_170 + " ");
                count_170++;
                _continue:
                k_170++;
            }
            Console.WriteLine("");
        }
        /*Bài 59: Nhập vào năm Dương lịch, xuất tên năm Âm lịch.Xuất năm Dương lịch kế
        tiếp có cùng tên năm Âm lịch.Biết bánh xe tính hai chu kỳ Can - Chi như sau:*/
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
        /*Bài 60: Viết chương trình thực hiện những yêu cầu sau:
        a.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên(n chẵn) có giá trị chứa
        trong đoạn[-100, 100] và xuất mảng.
        b.Viết hàm thực hiện việc trộn hoàn hảo(perfect shuffle) một mảng: sao cho
        các phần tử của một nửa mảng sau xen kẽ với các phần tử của một nửa mảng
        đầu.Xuất mảng sau khi trộn.
        c.Xác định số lần trộn hoàn hảo để mảng trở về như ban đầu.*/
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
        /*Bài 61: Viết chương trình thực hiện những yêu cầu sau:
        a.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên có giá trị chứa trong đoạn
        [-100, 100] và xuất mảng.
        b.Tính tổng các số nguyên dương có trong mảng.
        c.Xóa phần tử có chỉ số p(p nhập từ bàn phím) trong mảng*/
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
        /*Bài 62: Viết chương trình thực hiện những yêu cầu sau:
        a.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên dương có giá trị chứa
        trong đoạn[10, 20] và xuất mảng.
        b.Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵn
        hay không?
        c.Xác định xem mảng có cặp số nguyên tố cùng nhau (coprime) nào không.*/
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
        /*Bài 65: Viết chương trình thực hiện những yêu cầu sau:
        a.Tạo mảng một chiều n phần tử nguyên có giá trị nhập vào từ bàn phím.
        b.Tính trung bình cộng của các số nguyên âm lẻ có trong mảng.
        c.Xóa các phần tử có trị trùng nhau trong mảng, chỉ chừa lại một phần tử*/
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

