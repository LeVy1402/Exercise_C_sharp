using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Account
    {
        private int account_id;
        private string firstname;
        private string lastname;
        private decimal balance;

        public int AccountId { get { return account_id; } set { account_id = value; } }
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public decimal Balance { get { return balance; } set { balance = value; } }
        public Account(int account_id, string firstname, string lastname, decimal balance) 
        {
            AccountId = account_id;
            Firstname = firstname;
            Lastname = lastname;
            Balance = balance;
        }

        public Account() {
            
        }
        public void Show()
        {
            Console.WriteLine("Account ID: " + account_id);
            Console.WriteLine("Firstname: " + firstname);
            Console.WriteLine("Lastname: " + lastname);
            Console.WriteLine("Balance: " + balance);
        }
        public void Input()
        {
            Console.WriteLine("Account ID: ");
            account_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Firstname: ");
            firstname = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            lastname = Console.ReadLine();
            Console.WriteLine("Balance: ");
            balance = decimal.Parse(Console.ReadLine());
        }

    }
    class AccountList
    {
        List<Account> Accounts = new List<Account>();
        public void NewAccount()
        {
            Account account = new Account();
            account.Input();
            Accounts.Add(account);
        }
        public void SaveFile()
        {
            Console.WriteLine("Input file name to save: ");
            string filename = Console.ReadLine();

            try
            {
                FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);

                StreamWriter writer = new StreamWriter(output);

                foreach (Account account in Accounts)
                {
                    writer.WriteLine("{0},{1},{2},{3}", account.AccountId, account.Firstname, account.Lastname, account.Balance);
                }

                output.Close();
                writer.Close();
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void LoadFile()
        {
            Console.WriteLine("Input file name to load: ");
            string filename = Console.ReadLine();
            try{
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);

                string str;
                while((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');
                    Account acc = new Account(int.Parse(list[0]), list[1], list[2], decimal.Parse(list[3]));
                    Accounts.Add(acc);
                }
                input.Close();
                reader.Close();

            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Report()
        {
            // đít i rì pọt
            // bớt chúng ta méo cần :V
            // not rì pọt hia
        }
    }
    internal class Program
    {
        static void buildMenu()
        {
            Console.Clear();
            Console.WriteLine("Thêm 1 account (add)");
            Console.WriteLine("Lưu vào file (save)");
            Console.WriteLine("Load file (load)");
        }
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            while (true)
            {
                string func = "";
                buildMenu();
                Console.Write("Chọn chức năng: "); func = Console.ReadLine();
                switch (func.ToLower())
                {
                    case "add":
                        accountList.NewAccount();
                        break;
                    case "save":
                        accountList.SaveFile();
                        break;
                    case "load":
                        accountList.LoadFile();
                        break;
                    default: Console.WriteLine("Vui lòng chọn lại, không có chức năng phù hợp với key bạn nhập ({0})", func); break;
                }
                Console.ReadKey();
            }
        }
    }


}
