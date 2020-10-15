using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201013_DatabaseUzduotis
{
    class DBIrasuSukurimas
    {
        private ZmogausOrganaiConverterDataContext db { get; }
        public DBIrasuSukurimas(ZmogausOrganaiConverterDataContext db)
        {
            this.db = db;
        }

        public string Ivestis(string zinute)
        {
            Console.WriteLine(zinute);
            return Console.ReadLine();
        }

        public Zmogus IrasytiZmogu()
        {
            Zmogus naujasZmogus = new Zmogus();
            naujasZmogus.Vardas = Ivestis("Iveskite zmogaus varda:");
            naujasZmogus.Pavarde = Ivestis("Iveskite zmogaus pavarde:");
            naujasZmogus.Amzius = int.Parse(Ivestis("Amzius: "));
            naujasZmogus.Gyvas = bool.Parse(Ivestis("Ar jis gyvas? True/False"));
            naujasZmogus.Alkoholis = bool.Parse(Ivestis("Ar jis vartojo alkoholi? True/False"));
            naujasZmogus.Donoras = bool.Parse(Ivestis("Ar jis organu donoras? True/False"));
            naujasZmogus.Lytis = Ivestis("Lytis: ");
            naujasZmogus.Narkotikai  = bool.Parse(Ivestis("Ar jis vartojo narkotikus? True/False"));
            naujasZmogus.KraujoGrupe = Ivestis("Kokia kraujo grupe? ");
            naujasZmogus.Ugis = float.Parse(Ivestis("Ugis: "));
            naujasZmogus.Svoris = float.Parse(Ivestis("Svoris: "));
            return naujasZmogus;
        }

        public void ZmogausIrasymasIduomenuBaze()
        {
            Zmogus zm = IrasytiZmogu();
            db.Zmogus.InsertOnSubmit(zm);
            db.SubmitChanges();
        }

        public void OrganoIrasymas()
        {
            Organai org = new Organai();
            org.Pavadinimas = "blogasOrganas";
            org.ZmogausId = 3;
            db.Organais.InsertOnSubmit(org);
            db.SubmitChanges();
        }

        public void ZmogausElementai(int id)
        {
            IEnumerable<Zmogus> zmns =
                from zmogus in db.Zmogus
                where zmogus.Id == id
                select zmogus;
            Zmogus zm = zmns.Single();

            zm.Vardas = "iiiiiiiiiiiiiiiiiiiii";
            zm.Pavarde = "oooooooooooooooooooooooo";
            //db.Zmogus.
            var s = db.GetChangeSet();
            db.SubmitChanges();
        }
    }
}
