using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20201015_Asynchronus
{
    class Program
    {
        public static EventHandler pypsek;
        static void Main(string[] args)
        {
            pypsek += Pyp;
            Task t = new Task(() => { Issiuntimas1(); });
            Task t2 = new Task(() => { Issiuntimas2(); });
            Task t3 = new Task(() => { Issiuntimas3(); });
            t.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
            Console.Read();
        }

        public static void Pyp(object sender, EventArgs e)
        {
            Console.Beep();
        }

        public static async Task Issiuntimas1()
        {
            while(true)
            {
                OnPypsek();
                Thread.Sleep(5000);
            }            
        }
        public static async void Issiuntimas2()
        {
            while (true)
            {
                OnPypsek();
                Thread.Sleep(1234);
            }
        }

        public static async void Issiuntimas3()
        {
            while (true)
            {
                OnPypsek();
                Thread.Sleep(1849);
            }
        }

        public static void OnPypsek()
        {
            if(pypsek != null)
            {
                bool pyp = true;
                pypsek(pyp, EventArgs.Empty);
            }
        }
    }
}
