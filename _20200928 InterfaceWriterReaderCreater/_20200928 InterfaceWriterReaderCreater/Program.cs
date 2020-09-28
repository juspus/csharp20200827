using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_InterfaceWriterReaderCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtWriter txtfile = new TxtWriter();
            IWriter wrt = new TxtWriter();
            IReader rdr = new TxtWriter();
            ICreator crt = new TxtWriter();

            Gamintojas(txtfile);
            Parasykime(txtfile);
            Readeris(txtfile);
        }

        public static void Parasykime(IWriter writer)
        {
            writer.Write("dalykasdalykasdalykas");
        }

        public static void Readeris (IReader reader)
        {
            string nuskaityta = reader.Read();
        }

        public static void Gamintojas (ICreator creator)
        {
            creator.Create("bandymas");
        }
    }
}
