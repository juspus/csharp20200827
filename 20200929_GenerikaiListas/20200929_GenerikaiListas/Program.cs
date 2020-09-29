using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_GenerikaiListas
{
    class Program
    {
        static void Main(string[] args)
        {
            DuokEnumerable(new List<string>());
            DuokEnumerable(new string[2]);
            //DuokEnumerable(new List<int>());
            //DuokEnumerable(new double[0]);
            DuokEnumerable(new List<string>());

            Dictionary<string, string> klase = new Dictionary<string, string>();
            klase.Add("Justas", "desto");
            klase.Add("Vaidas", "klauso");
            klase.Add("Donatas", "klauso");
            //klase.Add("Justas", "klauso");

            Dictionary<int, Class1> intClass1 = new Dictionary<int, Class1>();
            intClass1.Add(5, new Class1());
            intClass1.Add(8, new Class1());

            foreach(var dictionaryElementas in klase)
            {
                Console.WriteLine(dictionaryElementas.Key);
            }
            foreach (var dictionaryElementas in klase)
            {
                Console.WriteLine(dictionaryElementas.Value);
            }

            foreach (var dictionaryElementas in klase)
            {
                Console.WriteLine(dictionaryElementas.Key + " "+ dictionaryElementas.Value);
                Console.WriteLine(dictionaryElementas);
            }

            Console.WriteLine("Justas dabar: " + klase["Justas"]);
            Console.WriteLine(klase["Vaidas"]);
            Console.WriteLine(klase[""]);

            Console.Read();

        }
        public static void DuokEnumerable(IEnumerable<string> en)
        {

        }
    }
}
