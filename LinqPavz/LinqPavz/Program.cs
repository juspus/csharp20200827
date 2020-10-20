using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPavz
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

        }

        public void LinqMetodas()
        {
            PrekiuKatalogasDataContext db = new PrekiuKatalogasDataContext();

            Preke preke = new Preke();
            preke.Kaina = 0;
            preke.Nuotrauka = "osigdjoiajg";
            preke.Pavadinimas = "pav";
            preke.Svoris = 0;

            db.Prekes.InsertOnSubmit(preke);
            db.SubmitChanges();
        }

        public void QueryMetodas()
        {
            SqlConnection sql;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\C#\\Pamokos\\10_22 atsiskaitymas\\MiniParduotuve\\MiniParduotuve\\Lenteles.mdf\";Integrated Security = True";
            sql = new SqlConnection(connectionString);

            string querry = "INSERT INTO Prekes(Pavadinimas, Kaina, Svoris, Nuotrauka) VALUES(@Pavadinimas, @Kaina, @Svoris, @Nuotrauka)";
            SqlCommand command = new SqlCommand(querry, sql);
            //Prekes ivedimas i duomenu baze.
            command.Parameters.AddWithValue("@Pavadinimas", PrekesPavadinimasTB.Text);
            command.Parameters.AddWithValue("@Kaina", double.Parse(PrekesKainaTB.Text));
            command.Parameters.AddWithValue("@Svoris", double.Parse(PrekesSvorisTB.Text));
            command.Parameters.AddWithValue("@Nuotrauka", NuotraukosPathTB.Text);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }
        
    }
}
