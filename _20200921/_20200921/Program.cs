using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class Program
    {
        static void Main(string[] args)
        {
            KrepsinioKamuolys kk = new KrepsinioKamuolys("Spalding", 20, false);

            while(!kk.Sproges)
            {
                kk.Mesti();
                kk.Info();
            }
            Console.Read();
        }
    }
}
