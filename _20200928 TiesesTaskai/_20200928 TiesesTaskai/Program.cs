using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_TiesesTaskai
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 pradziosTaskas = new Vector2();
            pradziosTaskas.Sukurti(1, 3);
            Taskas pabaigosTaskas = new Taskas(6, 6);
            pabaigosTaskas.Spausdinti();

            Vector2 tikrinimasTaskas = new Vector2();
            tikrinimasTaskas.Sukurti(3, 3);

            Linija lin = new Linija();
            lin.Sukurti(pradziosTaskas, pabaigosTaskas);
            Console.WriteLine(lin.ArTieseje(tikrinimasTaskas));
            tikrinimasTaskas.Spausdinti();
            Console.ReadLine();
        }
    }
}
