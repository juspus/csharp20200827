using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_InterfaceDaerbuotojas
{
    interface IDarbuotojas
    {
        string Vardas { get; }
        int Id { get; }

        void SpausdintiInfo();
    }
}
