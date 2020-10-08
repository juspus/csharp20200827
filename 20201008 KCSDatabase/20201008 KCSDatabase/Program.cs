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
            InsertStudents("Justas", "Puodzius", "+37068449321", "pastas@pastas.pastas");
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

    }
}
