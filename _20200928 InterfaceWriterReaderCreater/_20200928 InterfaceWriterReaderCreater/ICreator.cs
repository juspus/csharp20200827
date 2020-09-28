using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_InterfaceWriterReaderCreater
{
    interface ICreator
    {
        string Extension { get; }
        void Create(string path);
    }
}
