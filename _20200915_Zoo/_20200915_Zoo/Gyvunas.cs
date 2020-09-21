using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915_Zoo
{
    class Gyvunas
    {
        public Gyvunas(int id, string vardas, string rusis, string spalva, int kojuSk, string lytis, TimeSpan miegoTrukme, int akiuSkaicius, int narvoNr, DateTime maitinimoLaikas, DateTime gimtadienis, TimeSpan sotumoLaikas)
        {
            Id = id;
            Vardas = vardas;
            Rusis = rusis;
            Spalva = spalva;
            KojuSk = kojuSk;
            Lytis = lytis;
            _MiegoTrukme = miegoTrukme;
            AkiuSkaicius = akiuSkaicius;
            NarvoNr = narvoNr;
            MaitinimoLaikas = maitinimoLaikas;
            Gimtadienis = gimtadienis;
            SotumoLaikas = sotumoLaikas;


            _Miega = false;
            _Pamaitintas = false;

            Amzius = (int)((DateTime.Now-Gimtadienis).TotalDays/365);
        }

        protected bool Stuburas { get; set; }
        public int Id { get; }
        public string Vardas { get; }
        public string Rusis { get; }
        public double Ugis { get; set; }
        public double Svoris { get; set; }
        public int Amzius { get; private set; }
        public string Spalva { get; private set; }
        public int KojuSk { get; private set; }
        public string Lytis { get; }
        private TimeSpan _MiegoTrukme { get; set; }
        public int AkiuSkaicius { get; }
        public int NarvoNr { get; private set; }
        public DateTime MaitinimoLaikas { get; private set; }
        private bool _Pamaitintas { get; set; }
        private bool _Miega { get; set; }
        public DateTime Gimtadienis { get; }
        private TimeSpan SotumoLaikas { get; }

        public void SpausdintiInformacija()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Gyvuno ID: {0}, Vardas: {1}, Rusis: {2}, Amzius: {3}", Id, Vardas, Rusis, Amzius);
            Console.WriteLine("Ugis: {0}, Svoris: {1}, Lytis: {2}, Spalva: {3}",Ugis, Svoris, Lytis, Spalva);
            Console.WriteLine("Koju skaicius: {0}, Akiu skaicius: {1}", KojuSk, AkiuSkaicius);
            Console.WriteLine("Gimtadienis: {0}", Gimtadienis.Date.ToShortDateString());
            Console.WriteLine("Narvo numeris: {0}", NarvoNr);
            string miegoBusena = _Miega ?  "Miega" : "Atsikeles";
            Console.WriteLine("Miego busena: {0}", miegoBusena);
            string sotumas = MaitinimoSituacija() ? "Sotus" : "Alkanas";
            Console.WriteLine("Sotumas: {0}", sotumas);
        }

        private bool MaitinimoSituacija()
        {
            return DateTime.Now < MaitinimoLaikas;
        }

        public void Pamaitinti(double maistoMase)
        {
            _Pamaitintas = MaitinimoSituacija();
            if (_Pamaitintas)
            {
                Console.WriteLine("Gyvunas nera alkanas, jo maitinimo laikas: {0}", MaitinimoLaikas.ToString());
            }
            else
            {
                MaitinimoLaikas = DateTime.Now + SotumoLaikas;
                Svoris += maistoMase;
                Console.WriteLine("Gyvunas pamaitintas, kitas maitinimo laikas : {0}", MaitinimoLaikas.ToString());
            }
        }

        public void Perkelti (int naujasNarvoNr)
        {
            NarvoNr = naujasNarvoNr;
        }

        public void Pasensta()
        {
            Amzius = (int)((DateTime.Now - Gimtadienis).TotalDays / 365);
        }

    }
}
