using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string lytis = rng.Next(0, 1) == 0 ? "M" : "F";
            TimeSpan miegoTrukme = TimeSpan.FromHours(2);
            DateTime maitinimoLaikas = DateTime.Now-TimeSpan.FromHours(2.5);
            DateTime gimtadienis = DateTime.Parse("2001/03/10");

            List<Gyvunas> zoo = new List<Gyvunas>();
            Gyvunas gyvunas1 = new Gyvunas(0, "Dramblius", "Dramblys", "Pilkas", 4, lytis, miegoTrukme, 2, 5, maitinimoLaikas, gimtadienis, TimeSpan.FromHours(3));
            zoo.Add(gyvunas1);
            lytis = rng.Next(0, 1) == 0 ? "M" : "F";
            zoo.Add(new Gyvunas(1, "Simba", "Liutas", "Liutiskas", 4, lytis, TimeSpan.FromHours(4), 2, 8, maitinimoLaikas, DateTime.Parse("2003/05/06"), TimeSpan.FromHours(10)));
            zoo.Add(new Gyvunas(2, "Zevra", "Zebras", "Juoda/Balta", 4, "F", TimeSpan.FromHours(5.6), 2, 1, maitinimoLaikas, DateTime.Parse("2020/06/06"), TimeSpan.FromHours(4)));

            gyvunas1.Ugis = 300;
            gyvunas1.Svoris = 6000;

            foreach (Gyvunas gyvis in zoo)
            {
                gyvis.SpausdintiInformacija();
            }

            var tikslusGyvis = zoo[2];

            tikslusGyvis.SpausdintiInformacija();

            //gyvunas1.pasensta();
            //gyvunas1.spausdintiinformacija();

            //gyvunas1.pamaitinti(50);
            //gyvunas1.spausdintiinformacija();

            //gyvunas1.pamaitinti(50);
            //gyvunas1.perkelti(3);
            //gyvunas1.spausdintiinformacija();

            Console.Read();
        }
    }
}
