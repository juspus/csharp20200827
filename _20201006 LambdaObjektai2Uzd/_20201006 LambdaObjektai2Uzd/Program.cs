using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20201006_LambdaObjektai2Uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rinkinys> rinkiniai = new List<Rinkinys>();
            rinkiniai.Add(new Rinkinys(5, 8));
            rinkiniai.Add(new Rinkinys(1, 1));
            rinkiniai.Add(new Rinkinys(2, 1));
            rinkiniai.Add(new Rinkinys(0, 9));

            rinkiniai.ForEach(x => x.A++);
            IEnumerable<int> sudauginti = rinkiniai.Select(x => x.A * x.B);

            Action<Rinkinys> spausdinti = x => Console.WriteLine($"A {x.A} B {x.B}");
            rinkiniai.ForEach(spausdinti);

            Func<Rinkinys, int> sudetis = x => x.A + x.B;

            List<int> sudedami = rinkiniai.Select(sudetis).ToList();
            sudedami.ForEach(x => Console.WriteLine(x));

            rinkiniai.Max(x => x.A);
            rinkiniai.Max(x => x.B);
            Console.Read();
        }
    }
}
