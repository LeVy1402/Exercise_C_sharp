using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cat_170 cat_170 = new Cat_170();
            cat_170.eat_170();
            cat_170.makeSound_170();
            cat_170.run();
            Bird_170 bird_170 = new Bird_170();
            bird_170.eat_170();
            bird_170.makeSound_170();
            bird_170.fly_170();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat_170()
        {
            Console.WriteLine("Đồ ăn");
        }
        public virtual void makeSound_170()
        {
            Console.WriteLine("");
        }
    }
    class Cat_170 : Animal
    {
        public void run()
        {
            Console.WriteLine("Mèo chạy");

        }
        public override void eat_170()
        {
            Console.WriteLine("Mèo ăn cá");
        }
        public override void makeSound_170()
        {
            Console.WriteLine("Mèo kêu meo meo");
        }
    }
    class Bird_170 : Animal
    {
        public void fly_170()
        {
            Console.WriteLine("Chim bay cao");

        }
        public override void eat_170()
        {
            Console.WriteLine("Chim ăn sâu");
        }
        public override void makeSound_170()
        {
            Console.WriteLine("Chít chít");
        }
    }
}
