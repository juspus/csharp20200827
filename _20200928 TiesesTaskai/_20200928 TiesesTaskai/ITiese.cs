using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_TiesesTaskai
{
    interface ITiese
    {
        ITaskas Start {get;}
        ITaskas End {get;}

        void Sukurti(ITaskas start, ITaskas end);
        bool ArTieseje(ITaskas taskas);
    }
}
