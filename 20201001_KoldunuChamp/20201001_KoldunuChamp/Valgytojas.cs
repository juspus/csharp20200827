using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201001_KoldunuChamp
{
    public class Valgytojas: IFormattable
    {
        private int _Id { get; }
        public string _Vardas { get; }
        private int _KoldunuSkaicius { get; }
        private int _ValgymoRiba { get; }
        public double _ValgymoGreitis { get; private set; }

        public Valgytojas(string duomenuEilute)
        {            
            if(!duomenuEilute.Contains(","))
            {
                throw new ArgumentException("Blogas formatas!");
            }

            string[] duomenys = duomenuEilute.Split(',');
            if (duomenys.Length < 4)
            {
                throw new ArgumentException("Blogas formatas!");
            }

            _Id = int.Parse(duomenys[0]);
            _Vardas = duomenys[1];
            _KoldunuSkaicius = int.Parse(duomenys[2]);
            _ValgymoRiba = int.Parse(duomenys[3]);

            if(_KoldunuSkaicius>_ValgymoRiba)
            {
                throw new PrivalgytaKoldunuException(_KoldunuSkaicius, _ValgymoRiba);
            }
        }

        public bool ArDaugiauKoldunu(Valgytojas valg)
        {
            if(_KoldunuSkaicius > valg._KoldunuSkaicius)
            {
                return true;
            }
            return false;
        }

        public void SkaiciuotiValgymoGreiti(TimeSpan trukme)
        {
            if(trukme.TotalSeconds == 0)
            {
                throw new DivideByZeroException();
            }
            _ValgymoGreitis = _KoldunuSkaicius / trukme.TotalSeconds;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _Vardas;
        }
        public override string ToString()
        {
            return _Vardas;
        }
    }
}
