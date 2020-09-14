using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200914_NuskaitymasIsFailo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";

            StreamWriter sw = new StreamWriter(path);
            int skaicius = 0;

            while(skaicius<10)
            {
                skaicius++;
                sw.WriteLine("All work and no play makes Jack a dull boy");
                sw.WriteLine();
            }
            sw.Close();

            StreamReader sr = new StreamReader(path);

            string tekstas = sr.ReadToEnd();
            string eil = "";
            List<string> eilutes = new List<string>();
            while((eil = sr.ReadLine()) != null)
            {
                eilutes.Add(eil);
            }
            sr.Close();

            //Pirmas metodas kai sukuriam sarasa ir priskiriame jam 
            //pradines reiksmes is tekstinio failo
            List<string> eiles = new List<string>(File.ReadAllLines(path));


            //Antras metodas kai sukuriamas sarasas uz mus
            eiles = File.ReadAllLines(path).ToList();

            int skaitliukas = 0;
            foreach(string eile in eiles)
            {                
                if(string.IsNullOrEmpty(eile))
                {
                    Console.WriteLine(eile);
                }
                else
                {
                    Console.WriteLine("[{0}]{1}", skaitliukas, eile);
                    skaitliukas++;
                }                
            }
            
            Console.ReadLine();
        }
    }
}
