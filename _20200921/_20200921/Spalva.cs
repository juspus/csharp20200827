using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    public class Spalva
    {
        public int R { get; }// 0 - 255
        public int G { get; }
        public int B { get; }
        public int A { get; }// 0 - 100
        public string Pavadinimas { get; }

        public Spalva(int red, int green, int blue)
        {
            if(!(red < 0 || red>255) && (green >= 0 && green <= 255) && (blue > 0 && blue <= 255))
            {
                R = red;
                G = green;
                B = blue;
                A = 100;
            }
            else
            {
                Console.WriteLine("Bloga spalva!");
            }            
        }

        public Spalva(int red, int green, int blue, int alpha)
        {
            if (!(red < 0 || red > 255) && (green >= 0 && green <= 255) && (blue > 0 && blue <= 255) && (alpha > 0 && alpha <= 100))
            {
                R = red;
                G = green;
                B = blue;
                A = alpha;
            }
            else
            {
                Console.WriteLine("Bloga spalva!");
            }
        }

        public Spalva(Random rng)
        {
            R = rng.Next(0, 255);
            G = rng.Next(0, 255);
            B = rng.Next(0, 255);
            A = rng.Next(0, 100);
        }
        public Spalva()
        {
            R = 255;
            G = 255;
            B = 255;
            A = 0;
        }

        public void Info()
        {
            Console.WriteLine("R {0}, G {1}, B {2}, A {3}", R,G,B,A);
        }

        public void Info(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("{0}, {1}, {2}, {3}", R, G, B, A);
        }
    }
}
