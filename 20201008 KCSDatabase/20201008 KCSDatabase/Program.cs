using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201008_KCSDatabase
{
    class Program
    {
        static SqlConnection Sql;
        static void Main(string[] args)
        {            
            var ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp20200827\\20201008 KCSDatabase\\20201008 KCSDatabase\\KcsDatabase.mdf\";Integrated Security=True";
            Sql = new SqlConnection(ConnectionString);
            //InsertStudents("Justas", "Puodzius", "+37068449321", "pastas@pastas.pastas");
            //InsertStudents("Pustas", "Juodzius", "+37068981351", "info@gmail.com");
            //InsertStudents("Gustas", "Ruodzius", "+37066819898", "grp@outlook.com");
            //InsertStudents("Guste", "Puode", "+37062216516", "kgkoero@mailas.eu");
            //InsertStudents("Goda", "Toda", "+849819541", "pastelis@pastetas.psr");

            //InsertAddressForStudent(1, "LT", "Kaunas", "Gatve", "551651");
            //InsertAddressForStudent(1, "GB", "London", "evtag", "558881");
            //InsertAddressForStudent(2, "ZB", "Miestas", "esdftag", "5468881");
            //InsertAddressForStudent(2, "GN", "Miestelis", "evtafghd", "59841");
            //InsertAddressForStudent(3, "TD", "Miestelenas", "yryvtag", "158881");
            //InsertAddressForStudent(4, "FB", "Miesteliauskas", "evtdfg", "651881");
            //InsertAddressForStudent(5, "PT", "London", "gldk", "123581");

            //InsertMarkForStudent(1, "Pirmas", 2, DateTime.Now);
            //InsertMarkForStudent(1, "Antras", 8, DateTime.UtcNow);
            //InsertMarkForStudent(2, "Pirmas", 1, DateTime.Now);
            //InsertMarkForStudent(2, "Antras", 8, DateTime.UtcNow);
            //InsertMarkForStudent(3, "Pirmas", 3, DateTime.Now);
            //InsertMarkForStudent(3, "Antras", 10, DateTime.UtcNow);
            //InsertMarkForStudent(4, "Pirmas", 5, DateTime.Now);
            //InsertMarkForStudent(4, "Antras", 9, DateTime.UtcNow);
            //InsertMarkForStudent(5, "Pirmas", 7, DateTime.Now);
            //InsertMarkForStudent(5, "Antras", 9, DateTime.UtcNow);

            //Antras Puslapis
        }

        static void InsertStudents(string name, string surname, string phone, string email)
        {
            var query = "INSERT Students(Name, Surname, Phone, Email) VALUES(@Name, @Surname, @Phone, @Email)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surname", surname);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email);
            command.ExecuteNonQuery();
            Sql.Close();
        }

        static void InsertAddressForStudent(int studentId, string country, string city, string street, string postCode)        
        {
            var query = "INSERT StudentAdresses(StudentId, Country, City, Street, PostCode) VALUES(@StudentId, @Country, @City, @Street, @PostCode)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@Country", country);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@Street", street);
            command.Parameters.AddWithValue("@PostCode", postCode);
            command.ExecuteNonQuery();
            Sql.Close();
        }

        static void InsertMarkForStudent(int studentId, string title, int mark, DateTime time)
        {
            var query = "INSERT StudentMarks(StudentId, Title, Mark, Time) VALUES(@StudentId, @Title, @Mark, @Time)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Mark", mark);
            command.Parameters.AddWithValue("@Time", time);
            command.ExecuteNonQuery();
            Sql.Close();
        }
    }
}
