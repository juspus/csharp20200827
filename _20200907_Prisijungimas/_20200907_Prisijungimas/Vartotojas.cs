using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200907_Prisijungimas
{
    class Vartotojas
    {
        private string Vardas { get; }
        private string Slapt { get; }

        public Vartotojas(string Vardas, string Slapt)
        {
            this.Vardas = Vardas;
            this.Slapt = Slapt;
        }

        public bool ArEgzistuoja(string Vardas, string Slaptazodis)
        {            
            if(this.Vardas == Vardas && this.Slapt == Slaptazodis)
            {
                return true;
            }
            return false;
        }
    }
}
