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
        public double Radius { get; protected set; }
        public bool Sproges { get; protected set; }
        protected int MetimuSk { get; set; }
        public Spalva Spalva { get; }
        private static Random rng = new Random();
        
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
            
            if(rng.NextDouble()<0.1)
            {
                Sprogdinti();
            }
        }

        protected void Sprogdinti()
        {
            Sproges = true;
            Radius = 0;
            SprogimoGarsas();
        }

        protected virtual void SprogimoGarsas()
        {     
        }

        public virtual void Info()
        {
            Console.WriteLine("Firma: {0}", Firma);
            Console.WriteLine("Radius: {0}, Kamuolys atlaike {1} metimus.", Radius, MetimuSk);
            Spalva.Info();
        }
    }
}
