using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200914_NuskaitymasIsskirstymas
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "zmoniuDuomenys.txt";

            List<string> zmones = new List<string>(File.ReadAllLines(path));

            List<string> vardai = new List<string>();
            List<string> pavardes = new List<string>();
            List<int> amziai = new List<int>();

            //Cheat metodas
            foreach(string eil in zmones)
            {
                string[] zmog = eil.Split(',');
                vardai.Add(zmog[0]);
                pavardes.Add(zmog[1]);
                amziai.Add(Convert.ToInt32(zmog[2]));
            }

            //Hard work metodas
            foreach(string zmogus in zmones)
            {
                int count = 0;
                string reiksme = "";
                foreach(char c in zmogus)
                {
                    if(c == ',')
                    {
                        if(count == 0)
                        {
                            vardai.Add(reiksme);
                        }
                        else if( count == 1)
                        {
                            pavardes.Add(reiksme);
                        }
                        reiksme = "";
                        count++;
                    }
                    else
                    {
                        reiksme += c;
                    }
                }
                amziai.Add(Convert.ToInt32(reiksme));
            }            

            foreach (var vardas in vardai)
            {
                Console.WriteLine(vardas);
            }
            foreach(var pavarde in pavardes)
            {
                Console.WriteLine(pavarde);
            }
            foreach (var amzius in amziai)
            {
                Console.WriteLine(amzius);
            }

            Console.Read();
        }
    }
}
