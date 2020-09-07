using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200907ReferenceTypePvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = a;
            Console.WriteLine("a = {0}, b = {1}", a,b);
            a = 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.Read();
        }
    }
}
