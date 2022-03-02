using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FunctionOverLoding
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Add(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
        public float Add(float num1, float num2)
        {
            return (num1 + num2);
        }
        public string Add(string value1, string value2)
        {
            return (value1 + " " + value2);
        }
        static void Main(string[] args)
        {
            FunctionOverLoding objF = new FunctionOverLoding();
            Console.WriteLine("Add with two int parameter :" + objF.Add(3, 2));
            Console.WriteLine("Add with three int parameter :" + objF.Add(3, 2, 8));
            Console.WriteLine("Add with two float parameter :" + objF.Add(3f, 22f));
            Console.WriteLine("Add with two string parameter :" + objF.Add("hello", "world"));
            Console.ReadLine();
        }
    }
}
