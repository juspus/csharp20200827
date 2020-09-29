using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_InterfaceDaerbuotojas
{
    class Imone
    {
        public List<IDarbuotojas> Darbuotojai { get; set; }
        public Imone(IDarbuotojas steigejas)
        {
            Darbuotojai = new List<IDarbuotojas>();
            Darbuotojai.Add(steigejas);
        }

        public void VisuDarbuotojuInfo()
        {
            foreach(var darb in Darbuotojai)
            {
                darb.SpausdintiInfo();
            }
        }

        public void DarbuotojoInfo(int id)
        {
            Darbuotojai[id].SpausdintiInfo();
            Console.WriteLine("Bendras darbuotoju kiekis: {0}", Darbuotojai.Count());
        }

        public void TrueDarbuotojoInfo(int id)
        {            
            foreach(var d in Darbuotojai)
            {
                if(d.Id == id)
                {
                    d.SpausdintiInfo();
                    Console.WriteLine("Bendras darbuotoju kiekis: {0}", Darbuotojai.Count());
                    return;
                }
            }
            Console.WriteLine("Darbuotojas neegzistuoja.");
        }
    }
}
