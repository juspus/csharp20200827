using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20201006_LambdaDauginimas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number(int x) => x * x;
            Console.WriteLine(Number(20));
            Console.WriteLine("-----------------------");
            List<int> numbers = new List<int>() { 5, 9, 1, 8, 6, 3, 4, 8 };
            List<int> sudauginti = numbers.Select(x => x * x).ToList();
            sudauginti.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
