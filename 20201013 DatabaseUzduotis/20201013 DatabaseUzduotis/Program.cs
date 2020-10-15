using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201013_DatabaseUzduotis
{
    class Program
    {
        static ZmogausOrganaiConverterDataContext dataContext = new ZmogausOrganaiConverterDataContext();
        static void Main(string[] args)
        {
            GeruDonoruAtspaudinimas();
            MireNoAlco();
            Kenciantys();
            DBIrasuSukurimas irasai = new DBIrasuSukurimas(dataContext);
            //irasai.ZmogausIrasymasIduomenuBaze();
            irasai.OrganoIrasymas();
            irasai.ZmogausElementai(1);
            ZmogausElementai(1, new Organai());
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

        public static void Trinimas(Zmogus zm)
        {
            dataContext.Zmogus.DeleteOnSubmit(zm);
            dataContext.SubmitChanges();
        }

        public static void ZmogausElementai(int id, Organai organas)
        {
            organas.Pavadinimas = "test";
            IEnumerable<Zmogus> zmns =
                from zmogus in dataContext.Zmogus
                where zmogus.Id == id
                select zmogus;
            Zmogus zm = zmns.Single();

            zm.Organais.Add(organas);

            zm.Vardas = "iiiiiiiiiiiiiiiiiiiii";
            zm.Pavarde = "oooooooooooooooooooooooo";
            dataContext.SubmitChanges();
        }
    }
}
