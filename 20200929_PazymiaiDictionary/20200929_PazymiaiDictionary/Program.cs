using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_PazymiaiDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> pusmetis = new Dictionary<string, List<int>>();

            pusmetis.Add("Jonas", new List<int>() { 5, 8, 6, 8, 9, 1, 10, 10, 9 });
            pusmetis.Add("Justas", new List<int>() { 5, 10, 6, 7, 2, 1, 4, 10, 9 });
            pusmetis.Add("Rima", new List<int>() { 5, 8, 6, 5, 9, 1, 9, 10, 9 });
            pusmetis.Add("Ilona", new List<int>() { 3, 8, 1, 9, 9, 1, 3, 7, 9 });

            Dictionary<string, double> mokiniuVidurkiai = new Dictionary<string, double>();
            Dictionary<string, double> surikiuotas = new Dictionary<string, double>();
            List<double> kontroliniuVidurkiai = new List<double>();

            foreach(var i in pusmetis)
            {
                mokiniuVidurkiai.Add(i.Key, i.Value.Average());
            }

            for(int i=0; i< pusmetis.First().Value.Count; i++)
            {
                double avg = 0;
                foreach(var mok in pusmetis)
                {
                    avg+=mok.Value[i];
                }
                avg /= pusmetis.Count();
                kontroliniuVidurkiai.Add(avg);
            }

            
            int kiekis = mokiniuVidurkiai.Count();
            while (surikiuotas.Count()<kiekis)
            {
                KeyValuePair<string, double> mok = mokiniuVidurkiai.First();
                foreach (var i in mokiniuVidurkiai)
                {
                    if (mok.Value < i.Value)
                    {
                        mok = i;
                    }
                }
                surikiuotas.Add(mok.Key, mok.Value);
                mokiniuVidurkiai.Remove(mok.Key);
            }
            kontroliniuVidurkiai = kontroliniuVidurkiai.OrderByDescending(x => x).ToList();
            Console.Read();
            
        }
    }
}
