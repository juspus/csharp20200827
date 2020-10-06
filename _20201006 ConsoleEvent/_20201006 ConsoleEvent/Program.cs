using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20201006_ConsoleEvent
{
    class Program
    {
        public static event EventHandler EnterPaspaustas;
        public static string irasytaReiksme;
        static void Main(string[] args)
        {
            EnterPaspaustas += IsgirdauIrRasau;
            EnterPaspaustas += IsgirdauIrParasiauIXml;
            EnterPaspaustas += IsgirdauIrParasiau;

            Ivestis("Kazka irasyk!");
        }

        public static void Ivestis(string zinute)
        {
            Console.WriteLine(zinute);
            irasytaReiksme = Console.ReadLine();
            OnEnterPaspaustas();
        }

        public static void OnEnterPaspaustas()
        {
            if(EnterPaspaustas != null)
            {
                EnterPaspaustas(irasytaReiksme, EventArgs.Empty);
            }
        }

        public static void IsgirdauIrRasau(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("isgirdau.txt", (string)sender);
        }
        public static void IsgirdauIrParasiauIXml(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("isgirdau.xml", (string)sender);
        }
        public static void IsgirdauIrParasiau(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("isgirdau", (string)sender);
        }
    }    
}
