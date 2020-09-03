using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _20200903SkaitymasRasymasFailas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rasymas i faila
            //Pirmas var
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("Sveiki as esu stringas!");
            sw.WriteLine("Sveiki as esu stringas!");
            sw.WriteLine("Sveiki as esu stringas!");
            sw.WriteLine("Sveiki as esu stringas!");
            sw.WriteLine("Sveiki as esu stringas!");
            sw.WriteLine("Sveiki as esu stringas!");
            //sw.Flush();
            sw.Close();


            //Antras var
            using (StreamWriter writer = new StreamWriter("test2.jpg"))
            {
                writer.WriteLine("Sveiki as nesu nuotrauka!");
            }

            //Trecias var
            //File.WriteAllText("test3.failas", "Failu irasymas jega!");

            string tekstas = "nesamone\n" +
                "is naujos eilutes" + 5;

            //Pridejimo pvz
            File.AppendAllText("test3.failas", "Ir as galiu kazka prideti!");
            File.AppendAllText("test3.failas", tekstas);


            //Skaitymas is failo

            //1Var
            StreamReader sr = new StreamReader("test3.failas");
            tekstas = sr.ReadToEnd();
            Console.WriteLine(tekstas);

            //2Var
            string eilute = "";
            while (eilute != null)
            {
                eilute = sr.ReadLine();
                Console.WriteLine(eilute);
            }

            //3Var
            var test = File.ReadAllText("test3.failas");

            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
