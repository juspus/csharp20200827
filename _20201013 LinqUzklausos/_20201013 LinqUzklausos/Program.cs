using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201013_LinqUzklausos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zmogus> zmones = new List<Zmogus>();
            zmones.Add(new Zmogus(1, 57, 155));
            zmones.Add(new Zmogus(2, 80, 180));
            zmones.Add(new Zmogus(3, 72, 200));
            zmones.Add(new Zmogus(4, 150, 180));
            zmones.Add(new Zmogus(5, 12, 180));
            zmones.Add(new Zmogus(6, 89, 210));
            zmones.Add(new Zmogus(7, 45, 186));
            zmones.Add(new Zmogus(8, 75, 180));
            zmones.Add(new Zmogus(9, 60, 160));
            zmones.Add(new Zmogus(10, 65, 170));
            zmones.Add(new Zmogus(11, 150, 110));

            IEnumerable<Zmogus> virsvoris =
                from zmogus in zmones
                where zmogus.ApskaiciuotiKMI() > 25
                select zmogus;

            IEnumerable<Zmogus> idealu =
                from zmogus in zmones
                where zmogus.ApskaiciuotiKMI() < 25 && zmogus.ApskaiciuotiKMI() > 20
                select zmogus;

            foreach (var i in virsvoris)
            {
                Console.WriteLine($"ID: {i.Id}, KMI: {i.ApskaiciuotiKMI()}");
            }
            Console.WriteLine("_________________________________________");
            foreach (var i in idealu)
            {
                Console.WriteLine($"ID: {i.Id}, KMI: {i.ApskaiciuotiKMI()}");
            }
            Console.ReadLine();
            
        }
    }
}
