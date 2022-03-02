using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class HierarchicalInheritance
    {

        static void Main(string[] args)
        {
            Father f = new Father();
            f.display();
            Son s = new Son();
            s.display();
            s.displayOne();
            Daughter d = new Daughter();
            d.displayTwo();
            Console.ReadKey();
        }
        class Father
        {
            public void display()
            {
                Console.WriteLine("Display...");
            }
        }
        class Son : Father
        {
            public void displayOne()
            {
                Console.WriteLine("Display One");
            }
        }
        class Daughter : Father
        {
            public void displayTwo()
            {
                Console.WriteLine("Display Two");
            }
        }
    }
}