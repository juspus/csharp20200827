using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_InterfaceWriterReaderCreater
{
    class TxtWriter : IWriter, IReader, ICreator
    {
        private string path {get; set;}
        public string Extension {
            get
            {
                return ".txt";
            }
        }

        public void Create(string path)
        {
            System.IO.File.Create(path + Extension);
            this.path = path + Extension;
        }

        public string Read()
        {
            return System.IO.File.ReadAllText(path);
        }

        public void Write(string tekstas)
        {
            System.IO.File.WriteAllText(path, tekstas);
        }
    }
}
