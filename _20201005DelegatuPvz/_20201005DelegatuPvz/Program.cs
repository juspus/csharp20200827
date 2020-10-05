using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201005DelegatuPvz
{
    class Program
    {
        public delegate int Sudetis(int sk1, int sk2);
        public static int Add(int a, int b)
        {
            Console.WriteLine("!!!");
            return a + b;
        }
        public static int Daugyba(int a, int b)
        {
            Console.WriteLine("???");
            return a * b;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            Sudetis veiksmas = Add;
            //Console.WriteLine(veiksmas(a, b));
            veiksmas += Daugyba;
            veiksmas += Daugyba;
            veiksmas += Daugyba;
            veiksmas += Add;
            Console.WriteLine(veiksmas(a, b));
            Console.ReadLine();
        }
    }
}
