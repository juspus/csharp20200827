using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20201001_BendrineKlase
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice<string, int, double, Program> pl = new Practice<string, int, double, Program>();
            pl.SaugomasKintamasis = "8565";
            pl.BendrinisJTipas = 85;
            pl.BendrinisKTipas = 98;
            pl.BendrinisVTipas = new Program();

            var ats = (int)pl.BendrinisJTipas + 5;

            //var ats = pl.Duomenys();

            Practice<string, string, string, string> plstring = new Practice<string, string, string, string>();
            plstring.SaugomasKintamasis = "8565";
            plstring.BendrinisJTipas = "8.5";
            plstring.BendrinisKTipas = "98";
            plstring.BendrinisVTipas = "new Program()";

            Practice<int, string, string, string> plstrint = new Practice<int, string, string, string>();
            plstrint.SaugomasKintamasis = 5;
            plstrint.BendrinisVTipas = "dalykas";

            List<int> listint = new List<int>();
            List<Program> listProgram = new List<Program>();

            PracticeList<int> practiceListInt = new PracticeList<int>();
            practiceListInt.Add(8);
            practiceListInt.Add(5);
            practiceListInt.Add(9849849);

            PracticeList<string> prlstr = new PracticeList<string>();
            prlstr.Add("49849asdfasdf");

            Console.WriteLine(practiceListInt.GetItem(2));
            Console.ReadLine();
            PaprastaKlase pk = new PaprastaKlase();
            Program pr = pk.KazkoksKeistasMetodas<Program>(new Program());
        }
    }

    class Practice<T, K, J, V>
    {
        public K BendrinisKTipas { get; set; }
        public J BendrinisJTipas { get; set; }
        public V BendrinisVTipas { get; set; }
        public T SaugomasKintamasis { get; set; }

        public T Duomenys()
        {
            return SaugomasKintamasis;
        }
    }

    class PaprastaKlase
    {
        public T KazkoksKeistasMetodas<T>(T obj)
        {
            return obj;
        }
    }

    class PracticeList<T> where T:IComparable
    {
        private T[] items;
        public PracticeList()
        {
            items = new T[0];
        }
        public T GetItem(int index)
        {
            return items[index];
        }
        public void Add(T newItem)
        {
            T[] newItems = new T[items.Length + 1];
            for(int index = 0; index<items.Length; index++)
            {
                newItems[index] = items[index];
            }
            newItems[newItems.Length - 1] = newItem;
            items = newItems;
        }
    }

}
