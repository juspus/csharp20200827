using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200914_KlasesPavyzdys
{
    class Automobilis
    {
        private string Marke { get; set; }
        public string Modelis { get; }
        public int GamybosMetai { get; set; }
        public int Rida { get; set; }

        public Automobilis()
        {

        }
        public Automobilis(string mark, string mod, int gamybosMet, int rida)
        {
            Marke = mark;
            Modelis = mod;
            GamybosMetai = gamybosMet;
            Rida = rida;
        }
                
        public double KilometraiPerMetus()
        {
            int praejoMetai = 2020 - GamybosMetai;
            double ats = (double)Rida / praejoMetai;
            return ats;
        }

        public void DetiMarke(string marke)
        {
            Marke = marke;
        }

        public string GautiMarke()
        {
            return Marke;
        }

        public void SpausdintiInformacija()
        {
            Console.WriteLine("Sio automobilio marke: {0}, Modelis: {1}, Gamybos metai: {2} ir ji nuvaziavus {3} km.", Marke, Modelis, GamybosMetai, Rida);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listas = new List<string>();

            Automobilis menamas = new Automobilis();
            Automobilis manoAuto = new Automobilis("Mazda", "3", 2010, 165500);
            Automobilis auto2 = new Automobilis("Audi", "A4", 2005, 10000);

            menamas.SpausdintiInformacija();
            menamas.DetiMarke("BMW");
            menamas.Rida = 500000;
            menamas.GamybosMetai = 2005;
            menamas.SpausdintiInformacija();

            Console.WriteLine(manoAuto.GautiMarke());
            manoAuto.DetiMarke("Toyota");
            Console.WriteLine(manoAuto.GautiMarke());
            //Console.WriteLine(manoAuto.Modelis);
            //Console.WriteLine(auto2.Marke);
            //Console.WriteLine(auto2.Modelis);

            manoAuto.SpausdintiInformacija();
            auto2.SpausdintiInformacija();

            Console.ReadLine();
        }
    }
}
