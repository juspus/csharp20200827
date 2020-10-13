using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201013_DatabaseUzduotis
{
    class Program
    {
        static ZmogausOrganaiConverterDataContext dataContext;
        static void Main(string[] args)
        {
            dataContext = new ZmogausOrganaiConverterDataContext();

            GeruDonoruAtspaudinimas();
            MireNoAlco();
            Kenciantys();
            Console.ReadLine();
        }

        public static void GeruDonoruAtspaudinimas()
        {
            IEnumerable<Zmogus> geriDonorai =
                from zmogus in dataContext.Zmogus
                where zmogus.Donoras == true
                where zmogus.Gyvas == true
                where zmogus.Narkotikai == false
                where zmogus.Alkoholis == false
                select zmogus;


            foreach (var i in geriDonorai)
            {
                Console.WriteLine("________________________________");
                Console.WriteLine($"{i.Id}, {i.Vardas}, {i.Amzius}");

                foreach (var organas in i.Organais)
                {
                    Console.WriteLine($"{organas.Pavadinimas}");
                }
                var suma = i.Organais.Sum(x => x.Kaina);
                Console.WriteLine("Organu suma: " + suma);

            }
        }

        public static void MireNoAlco()
        {
            List<Zmogus> mireNoAlko = dataContext.Zmogus.Where(zmogus => zmogus.Alkoholis == false && zmogus.Gyvas == false).ToList();
            Console.WriteLine("_______________________________________");
            foreach(var i in mireNoAlko)
            {
                Console.WriteLine($"{i.Id}, {i.Vardas}, {i.Amzius}");
            }
        }

        public static void Kenciantys()
        {
            IEnumerable<Zmogus> kencia =
                from zmogus in dataContext.Zmogus
                where zmogus.Gyvas == true
                from organas in zmogus.Organais
                where organas.Skauda == true
                select zmogus;
            Console.WriteLine("______________________________________");
            foreach (var i in kencia)
            {
                Console.WriteLine($"{i.Id}, {i.Vardas}, {i.Amzius}");
            }
        }
    }
}
