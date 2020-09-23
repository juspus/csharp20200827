using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class Program
    {
        private static Random rng;
        static void Main(string[] args)
        {

            /*Aprašymas:
             * Susikūrėme Spalvos klasę su 4 spalvos kanalais
             * Susikūrėme Kamulio klasę, kuris turėjo spindulį, sprogimo indikatorių, firmos pavadinimą ir spalvą, kuri buvo mūsų spalvos klasės objektas
             * Kamuolio klasė turi virtualų sprogimo garso metodą, kuris į consolę atspausdina sprogimo garsą.
             * Kamuolio klasė turi sprogdinimo metodą, kurį iškviečiame kamuoliui sprogstant - jis pakeičia spindulį ir sprogimo indikatorių.
             * Kamuolio klasė turi virtualų metimo metodą kuris pagal atsitiktinių skaičių generatorių bando susprogdinti kamuolį naudodamas sprogdinti metodą ir jei kamuolys nesprogęs jį meta prideda prie metimu skaičiaus atributo 1.
             * Kamuolio klasė turi virtualų informacijos metodą, kuris atspausdina spindulį, spalvą, firmą ir metimų skaičių.
             * Susikūrėme 3 skirtingas klases, kurios paveldi kamuolio bazinę klasę: Tinklinio, Teniso, Krepsinio Kamuoliai.
             * Kiekviena iš jų gavo papildomą atributą ,kuris nurodė kamuolio tipą.
             * Taip pat jose buvo perrašomas sprogimo garso metodas (override) ir nurodomas skirtingas sprogimo garsas, kurį išleidžia sprogstantis kamuolys.
             * Su override perrašomi informacijos metodas kiekienoje klasėje, kuris papildomai atspausdina ir kamuolio atitinkamą kamuolio tipą.
             * 
             * Boulingo kamuolys yra išskirtinis, kad jame pridėjome daugiau atributų, bei perrašėme (override) mesti metodą, kad kamuolys sprogtų tik po galiojimo pabaigos.
             * 
             * Pagrindinėje programoje susikūrėme pagalbinių metodų ir mėteme kamuolius tol, kol visi jie sprogo. Atspasudindami informaciją prieš metimus, po metimų ir sprogimo garsą.
             * 
             * */
            rng = new Random();
            int kamuoliuKiekis = rng.Next(20, 100);
            List<Kamuolys> pintine = UzpildauRusiKamuoliais(kamuoliuKiekis);

            //Kamuolių mėtymo ciklas
            foreach(Kamuolys ball in pintine)
            {
                ball.Info();
                while (!ball.Sproges)
                {
                    ball.Mesti();                    
                }
                ball.Info();
                Console.WriteLine("______________________________");
            }

            Console.Read();
        }

        /// <summary>
        /// Metodas, kuris mums sugeneruoja tam tikrą kiekį atsitiktinių kamulių, juos sudeda į sąrašą
        /// </summary>
        /// <param name="kiekis">Atsitiktinis kamuolių kiekis, kurį norime sugeneruoti.</param>
        /// <returns>Suvestą kamuolių sąrašą</returns>
        public static List<Kamuolys> UzpildauRusiKamuoliais(int kiekis)
        {
            List<Kamuolys> rusys = new List<Kamuolys>();
            for(var i = 0; i<kiekis; i++)
            {
                rusys.Add(KamuolioGeneravimas());
            }
            return rusys;
        }
        /// <summary>
        /// Iš masyvo su firmų pavadinimais atsitiktinai parenkame vieną iš firmos pavadinimų.
        /// </summary>
        /// <param name="firmos">Masyvas su įrašytomis žinomomis firmomis.</param>
        /// <returns></returns>
        public static string FirmosPavadinimoParinkimas(string[] firmos)
        {            
            return firmos[rng.Next(0, firmos.Length)];
        }
        /// <summary>
        /// Atsitiktinai parenkamas kamuolio tipas ir jis sugeneruojamas kaip paprastas kamuolys.
        /// </summary>
        /// <returns>Atsitiktinio tipo kamuolį. Nes visi tie tipai yra kamuoliai, tik kitokie.</returns>
        public static Kamuolys KamuolioGeneravimas()
        {
            int rngSk = rng.Next(0, 3);

            string[] firmos = { "Maxima", "MBA", "UAB Perkunas", "Snaige", "Kamuoliu Gamintojas" };
            string firmosPav = FirmosPavadinimoParinkimas(firmos);
            bool tipas = rng.NextDouble() < 0.5;
            if (rngSk == 0)
            {
                return new KrepsinioKamuolys(firmosPav,rng.Next(20,30), tipas);
            }
            else if(rngSk == 1)
            {
                return new TinklinioKamuolys(firmosPav, rng.Next(20, 30), tipas, new Spalva(rng));
            }
            else if(rngSk == 2)
            {
                return new TenisoKamuolys(firmosPav, rng.Next(5, 15), new Spalva(rng), TenisoKamuolys.AtsitiktinisTipas(rng));
            }
            else
            {
                return null;
            }
        }

    }
}
