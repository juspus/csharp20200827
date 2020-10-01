using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20201001_KoldunuChamp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> duomenys = File.ReadAllLines("championship.txt").ToList();
            TimeSpan trukme = TimeSpan.FromMinutes(60);
            List<Valgytojas> valgytojai = new List<Valgytojas>();
            foreach (var duomuo in duomenys)
            {
                try
                {
                    valgytojai.Add(new Valgytojas(duomuo));
                }
                catch(PrivalgytaKoldunuException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Valgytojas laimetojas = valgytojai.First();
            foreach(var valg in valgytojai)
            {
                try
                {
                    valg.SkaiciuotiValgymoGreiti(trukme);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine(ex);
                }
                
                if(!laimetojas.ArDaugiauKoldunu(valg))
                {
                    laimetojas = valg;
                }
            }

            Console.WriteLine(laimetojas);
            Console.ReadLine();
        }
    }
}
