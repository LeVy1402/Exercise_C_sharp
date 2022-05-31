using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    interface IBook
    {
        string this[int index] { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }  
        string ISBN { get; set; }
        int Year { get; set; }
        void Show();
    }
    class Book : IBook
    {
        private string title;
        private string author;
        private string publisher;
        private string isbn;
        private int year;
        private ArrayList chapter = new ArrayList();
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                {
                    return (string)chapter[index];
                }
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value;
                } else if (index == chapter.Count)
                {
                    chapter.Add(value);
                } else
                    throw new IndexOutOfRangeException();
            }
        }
        public string Title { get { return title; } set { this.title = value; } }
        public string Author { get { return author; } set { this.author = value; } }
        public string Publisher { get { return publisher; } set { this.publisher = value; } }   
        public string ISBN { get { return isbn; } set { this.isbn = value; } }
        public int Year { get { return year; } set { this.year = value; } }

        public void Show()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Chapter: ");
            for (int i=0; i<chapter.Count; i++)
            {
                Console.WriteLine("\t {0}: {1}", i + 1, chapter[i]);
            }
            Console.WriteLine("----------------------------------");
        }
        public void Input()
        {
            Console.Write("Input title: ");
            title = Console.ReadLine();
            Console.Write("Input author: ");
            author = Console.ReadLine();
            Console.Write("Input publisher: ");
            publisher = Console.ReadLine();
            Console.Write("Input isbn: ");
            isbn = Console.ReadLine();
            Console.Write("Input year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Chapter: ");
            string str;
            do
            {
                Console.Write("\t");
                str = Console.ReadLine();               
                if (str.Length > 0)
                {
                    chapter.Add(str);
                }

            } while (str.Length > 0);
        }
    }
    class BookList
    {
        List<Book> books = new List<Book>();       
        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            books.Add(b);
        }
        public void ShowList()
        {
            foreach(Book b in books)
            {
                b.Show();
            }
        }
        public void InputBook()
        {
            Console.Write("Amont of Book ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AddBook();
            }
        }
        public void sortList(string orderBy)
        {
            switch(orderBy.ToLower()){
                case "title": books = books.OrderBy(b => b.Title).ToList(); break;
                case "author": books = books.OrderBy(b => b.Author).ToList(); break;
                case "publisher": books = books.OrderBy(b => b.Publisher).ToList(); break;
                case "year": books = books.OrderBy(b => b.Year).ToList(); break;
            }

            Console.WriteLine("Books list sort alphabet by " + orderBy);        
            ShowList();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;         
            BookList bk = new BookList();
            bk.InputBook();
            bk.ShowList();
            Console.WriteLine("Input type sort ");
            type = Console.ReadLine();
            bk.sortList(type);
            Console.ReadKey();
            
        }
    }
}
