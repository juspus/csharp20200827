using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    public class Kamuolys
    {
        public string Firma { get; }
        public double Radius { get; private set; }
        public bool Sproges { get; private set; }
        private int MetimuSk { get; set; }
        public Spalva Spalva { get; }
        private Random rng = new Random();
        
        public Kamuolys(string firma, double radius, Spalva spalva)
        {
            Firma = firma;
            Radius = radius;
            Sproges = false;
            Spalva = spalva;
            MetimuSk = 0;
        }

        public virtual void Mesti()
        {
            if(!Sproges)
            {
                MetimuSk++;
            }
            
            if(rng.NextDouble()<0.3)
            {
                Sprogdinti();
            }
        }

        protected virtual void Sprogdinti()
        {
            Sproges = true;
            Radius = 0;
            Console.WriteLine("Pop");
        }

        public void Info()
        {
            Console.WriteLine("Radius: {0}", Radius);
        }
    }
}
