using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_AbstraktusFigurosPlotas
{
    abstract class Figura
    {
        public double Plotas { get; protected set; }
        public abstract double SkaiciuotiPlota();
    }

    class Staciakampis : Figura
    {
        public double Ilgis { get; }
        public double Plotis { get; }
        public Staciakampis(double ilgis, double plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }
        public override double SkaiciuotiPlota()
        {
            Plotas = Ilgis* Plotis;
            return Plotas;
        }
    }

    class Trikampis : Figura
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Trikampis(double a, double b, double c)
        {
            double A = a;
            double B = b;
            double C = c;
        }
        public override double SkaiciuotiPlota()
        {
            var p = (A + B + C) / 2;
            Plotas = Math.Sqrt((p - A)*(p - B)*(p - C)*p);
            return Plotas;
        }
    }

    class Skritulys : Figura
    {
        public double Radius { get; }

        public Skritulys(double radius)
        {
            double Radius = radius;
        }
        public override double SkaiciuotiPlota()
        {
            Plotas = Radius * Radius * Math.PI;
            return Plotas;
        }
    }
}
